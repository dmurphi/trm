using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Triemli.Controllers
{
    public class FileController : Controller
    {

        [HttpPost]
        public void UploadFile(HttpPostedFileBase FileUpload)
        {
            if (FileUpload.ContentLength > 0)
            {
               
            }

            Response.Write("Fucking file uploaded");

        }
    }
}
