using DocuVaultApp.Data;
using DocuVaultApp.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DocuVaultApp.Pages.Documents
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Document> Documents { get; set; } = new List<Document>();

        // Pagination properties
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 12; // Number of documents per page
        public int TotalPages { get; set; }

        public void OnGet(int? pageNumber)
        {
            PageNumber = pageNumber ?? 1;

            int totalDocuments = _context.Documents.Count();
            TotalPages = (int)Math.Ceiling(totalDocuments / (double)PageSize);

            Documents = _context.Documents
                .OrderByDescending(d => d.UploadDate)
                .Skip((PageNumber - 1) * PageSize)
                .Take(PageSize)
                .ToList();
        }
    }
}

