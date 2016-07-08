using System;
using Picturra.Data.Contracts;
using Picturra.Models.Profile;

namespace Picturra.Presenter.Commands
{
    public class GetContactByUserGuid : ICommand<Guid, Contact>
    {
        private readonly IContactRepository _contactRepository;

        public GetContactByUserGuid(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }
        public Guid Input { get; set; }
        public Contact Value { get; set; }
        public void Execute()
        {
            Value = _contactRepository.GetContactByLoginId(Input);
        }
    }
}