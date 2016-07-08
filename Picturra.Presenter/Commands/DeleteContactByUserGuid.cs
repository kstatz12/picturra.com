using System;
using Picturra.Data.Contracts;

namespace Picturra.Presenter.Commands
{
    public class DeleteContactByUserGuid : IWriteCommand<Guid>
    {
        private readonly IContactRepository _contactRepository;
        public DeleteContactByUserGuid(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }
        public Guid Input { get; set; }
        public void Execute()
        {
            _contactRepository.DeleteContactByLoginId(Input);
        }
    }
}