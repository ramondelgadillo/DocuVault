using DocuVaultApp.Data;
using DocuVaultApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace DocuVaultApp.Pages.Documents
{
    public class UploadModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _environment;

        public UploadModel(ApplicationDbContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        [BindProperty]
        public Document Document { get; set; } = new Document(); // Initialize to avoid null warnings

        [BindProperty]
        public IFormFile? UploadedFile { get; set; } // Nullable, form might not submit file

        // ---------------- NEW ----------------
        [TempData] // CHANGED: added TempData to store success message
        public string? SuccessMessage { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || UploadedFile == null)
            {
                return Page();
            }

            var uploadsFolder = Path.Combine(_environment.WebRootPath, "uploads");
            if (!Directory.Exists(uploadsFolder))
            {
                Directory.CreateDirectory(uploadsFolder);
            }

            var filePath = Path.Combine(uploadsFolder, UploadedFile.FileName);
            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await UploadedFile.CopyToAsync(fileStream);
            }

            Document.FilePath = "/uploads/" + UploadedFile.FileName;
            Document.UploadDate = System.DateTime.Now;

            _context.Documents.Add(Document);
            await _context.SaveChangesAsync();

            // ---------------- NEW ----------------
            SuccessMessage = "✅ Document uploaded successfully!"; // CHANGED: set message for toast

            return RedirectToPage("/Documents/Index"); // Make sure it redirects to the documents list
        }
    }
}
