using System.Data.Entity.Infrastructure;
using Microsoft.Practices.Unity;
using System.Web;
using System.Web.Mvc;
using Microsoft.Practices.Unity.Mvc;
using System.Data.Entity;
using Picturra.com.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using Picturra.com.Controllers;
using Picturra.Data;
using Picturra.Data.Contracts;
using Picturra.Helpers.cs;
using Picturra.Models.Profile;
using Picturra.Presenter;
using Picturra.Presenter.Adapters;
using Picturra.Presenter.Commands;
using Picturra.Presenter.Contracts;
using ServiceStack;
using ServiceStack.OrmLite;
using ServiceStack.OrmLite.SqlServer;
using IDbConnectionFactory = ServiceStack.Data.IDbConnectionFactory;

namespace Picturra.com
{
    public static class Bootstrapper
    {
        public static UnityContainer Initialize()
        {
            var container = BuildUnityContainer();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            return container;
        }

        public static UnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();
            RegisteryTypes(container);
            return container;
        }

        private static void RegisteryTypes(UnityContainer container)
        {
            RegisterApplicationIdentity(container);
            RegisterRepositories(container);
            RegisterSericeAdapters(container);
            RegisterCommandHelpers(container);
            RegisterPresenters(container);

        }

        private static void RegisterApplicationIdentity(IUnityContainer container)
        {
            container.RegisterType<DbContext, ApplicationDbContext>(new HierarchicalLifetimeManager());

            container.RegisterType(typeof(UserManager<>), new InjectionConstructor(typeof(IUserStore<>)));
            container.RegisterType<IUser>(new InjectionFactory(c => c.Resolve<IUser>()));
            container.RegisterType(typeof(IUserStore<>), typeof(UserStore<>));
            container.RegisterType<IdentityUser, ApplicationUser>(new ContainerControlledLifetimeManager());

            container.RegisterType<UserManager<ApplicationUser>>(new HierarchicalLifetimeManager());
            container.RegisterType<IUserStore<ApplicationUser>, UserStore<ApplicationUser>>(new HierarchicalLifetimeManager());

            container.RegisterType<IAuthenticationManager>(new InjectionFactory(c => HttpContext.Current.GetOwinContext().Authentication));
            container.RegisterType<AccountController>(new InjectionConstructor());

        }


        private static void RegisterPresenters(IUnityContainer container)
        {
            container.RegisterType<IUploadPresenter, UploadPresenter>(new HierarchicalLifetimeManager());
            container.RegisterType<IProfilePresenter, ProfilePresenter>(new HierarchicalLifetimeManager());
        }
        private static void RegisterSericeAdapters(UnityContainer container)
        {
            container.RegisterType<ICloudinaryAdapter, CloudinaryAdapter>(new HierarchicalLifetimeManager());
        }

        private static void RegisterCommandHelpers(UnityContainer container)
        {
            container.RegisterType<ICommandInvoker, CommandInvoker>(new HierarchicalLifetimeManager());
        }

        private static void RegisterRepositories(IUnityContainer container)
        {
            var connectionString = ConfigurationHelper.GetPicturraConnectionString();
            var connectionFactory = new OrmLiteConnectionFactory(connectionString, SqlServerDialect.Provider);

            var connectionFactoryConstructor = new InjectionConstructor(connectionFactory);

            container.RegisterType<IContactRepository, ContactRepository>(connectionFactoryConstructor);

            ConfigureDb(connectionFactory);
        }

        private static void ConfigureDb(IDbConnectionFactory connectionFactory)
        {
            using (var db = connectionFactory.Open())
            {
                db.CreateTable<Picturra.Models.Data.Contact>(overwrite: false);
            }
        }



    }
}