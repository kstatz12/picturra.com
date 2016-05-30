using System;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Picturra.Models.Image;
using Picturra.Presenter.Contracts;

namespace Picturra.com.Controllers
{
    public class UploadController : Controller
    {
        private readonly IUploadPresenter _uploadPresenter;
        public UploadController(IUploadPresenter uploadPresenter)
        {
            _uploadPresenter = uploadPresenter;
        }

        public JsonResult Upload()
        {
            HttpPostedFileBase fileData = null;
            if (Request.Files.Count > 0)
            {
                fileData = Request.Files[0];
            }


            if (fileData != null)
            {
                var imageUpload = new ImageUpload
                {
                    File = fileData.InputStream,
                    Ip = Request.UserHostAddress,
                    FileName = fileData.FileName,
                    User = Guid.NewGuid()
                };
                var retVal = _uploadPresenter.UploadImage(imageUpload);
                return Json( new { Image = retVal });
            }
            return Json(new {Image = string.Empty});
        }
    }
}