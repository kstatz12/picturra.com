using Picturra.Data.Contracts;
using Picturra.Models.Profile;
using Picturra.Presenter.Commands;
using Picturra.Presenter.Contracts;
using UpdateContact = Picturra.Presenter.Commands.UpdateContact;

namespace Picturra.Presenter
{
    public class ProfilePresenter : IProfilePresenter
    {
        private readonly ICommandInvoker _commandInvoker;
        private readonly IContactRepository _contactRepository;
        public ProfilePresenter(ICommandInvoker commandInvoker, IContactRepository contactRepository)
        {
            _commandInvoker = commandInvoker;
            _contactRepository = contactRepository;
        }

        public void CreateContact(Contact contact)
        {
            _commandInvoker.Invoke(new SaveContact(_contactRepository), contact);
        }

        public Contact GetContact(System.Guid loginId)
        {
            return _commandInvoker.Invoke(new GetContactByUserGuid(_contactRepository), loginId);
        }

        public void DeleteContact(System.Guid loginId)
        {
            _commandInvoker.Invoke(new DeleteContactByUserGuid(_contactRepository), loginId);
        }

        public void UpdateContact(Contact contact)
        {
            _commandInvoker.Invoke(new UpdateContact(_contactRepository), contact);
        }
    }
}