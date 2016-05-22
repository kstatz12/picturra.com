using Picturra.Presenter.Adapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picturra.Presenter.Commands
{
    public class DeleteImage : IWriteCommand<string>
    {
        private readonly ICloudinaryAdapter _cloudinaryAdapter;
        public DeleteImage(ICloudinaryAdapter cloudinaryAdpater)
        {
            _cloudinaryAdapter = cloudinaryAdpater;
        }

        public string Input { get; set; }

        public void Execute()
        {
            _cloudinaryAdapter.DeleteImage(Input);
        }
    }
}
