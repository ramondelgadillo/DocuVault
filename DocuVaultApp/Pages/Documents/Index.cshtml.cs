// File: Pages/Documents/Index.cshtml.cs
using DocuVaultApp.Data;
using DocuVaultApp.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocuVaultApp.Pages.Documents
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        // Renamed from RecentDocuments to Documents to match Razor page
        public IList<Document> Documents { get; set; } = new List<Document>();

        public async Task OnGetAsync()
        {
            Documents = await _context.Documents
                .OrderByDescending(d => d.UploadDate)
                .Take(6)
                .ToListAsync();
        }
    }
}
