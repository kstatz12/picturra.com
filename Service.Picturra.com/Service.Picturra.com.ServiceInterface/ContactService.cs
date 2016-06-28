using Service.Picturra.com.ServiceModel;

namespace Service.Picturra.com.ServiceInterface
{
    public class ContactService : ServiceStack.Service
    {
        public object Get(GetContact contact)
        {
            return new ContactResponse();
        }

        public object Get(GetContactById contact)
        {
            return new ContactResponse();
        }

        public object Put(UpdateContact contact)
        {
            return new ContactResponse();
        }

        public object Post(UpdateContact contact)
        {
            return new ContactResponse();
        }

        public object Delete(DeleteContact contact)
        {
            return true;
        }
    }
}
