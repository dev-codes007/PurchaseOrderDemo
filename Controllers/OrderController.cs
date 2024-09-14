using Microsoft.AspNetCore.Mvc;


namespace PurchaseOrderDemo.Controllers
{
    [Route("[controller]")]
    public class OrderController : Controller
    {
        [HttpGet("Upload")]
        public IActionResult Upload()
        {
            return View();
        }

        [HttpPost("UploadPurchaseOrder")]
        public async Task<IActionResult> UploadPurchaseOrder(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return Json(new { success = false, message = "No file selected." });
            }

            var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads");
            if (!Directory.Exists(uploadsFolder))
            {
                Directory.CreateDirectory(uploadsFolder);
            }

            var filePath = Path.Combine(uploadsFolder, file.FileName);
            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }

            var fileUrl = Url.Content($"~/uploads/{file.FileName}");
            return Json(new { success = true, url = fileUrl });
        }
    }
}