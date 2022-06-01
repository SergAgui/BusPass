using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QRCoder;
using System.Drawing;

namespace BusPass.Controllers
{
    public class QRCodeController : Controller
    {
        QRCodeGenerator codeGenerator = new QRCodeGenerator();
        
        // GET: QRCodeController
        public ActionResult Index()
        {
            QRCodeData codeData = codeGenerator.CreateQrCode("Some text to fill", QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(codeData);
            Bitmap qrImage = qrCode.GetGraphic(20);
            
            return View();
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
