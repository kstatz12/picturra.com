using Picturra.Data.Contracts;
using Picturra.Models.Profile;

namespace Picturra.Presenter.Commands
{
    public class UpdateContact : IWriteCommand<Contact>
    {
        private readonly IContactRepository _contactRepository;
        public UpdateContact(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }
        public Contact Input { get; set; }
        public void Execute()
        {
            _contactRepository.Update(Input);
        }
    }
}