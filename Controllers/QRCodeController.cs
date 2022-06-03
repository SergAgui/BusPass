using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QRCoder;

namespace BusPass.Controllers
{
    public class QRCodeController : Controller
    {
        QRCodeGenerator codeGenerator = new QRCodeGenerator();
        
        // GET: QRCodeController
        public ActionResult Index()
        {
            return View();
        }

        private static Byte[] BitmapToBytes(Bitmap img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        // POST: QRCodeController
        [HttpPost]
        public IActionResult Index(string qrText)
        {
            QRCodeData codeData = codeGenerator.CreateQrCode(qrText, QRCodeGenerator.ECCLevel.Q);
            string fileGuid = Guid.NewGuid().ToString().Substring(0,4);
            codeData.SaveRawData("wwwroot/qrr/order-" + fileGuid + ".qrr", QRCodeData.Compression.Uncompressed);
            QRCode qrCode = new QRCode(codeData);
            Bitmap qrImage = qrCode.GetGraphic(20);
            return View(BitmapToBytes(qrImage));
        }

        // GET: QRCodeController/Add
        public ActionResult Add()
        {
            return View();
        }

        // POST: QRCodeController/Add
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: QRCodeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: QRCodeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
