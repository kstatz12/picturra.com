using Picturra.Data.Contracts;
using Picturra.Models.Data;
using Contact = Picturra.Models.Profile.Contact;

namespace Picturra.Presenter.Commands
{
    public class SaveContact : IWriteCommand<Contact>
    {
        private readonly IContactRepository _contactRepository;
        public SaveContact(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }
        public Contact Input { get; set; }
        public void Execute()
        {
            _contactRepository.Save(Input);
        }
    }
}