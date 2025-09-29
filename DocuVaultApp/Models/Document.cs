using System;

namespace DocuVaultApp.Models
{
    public class Document
    {
        public int Id { get; set; }

        // Document properties
        public string? Title { get; set; }
        public string? Description { get; set; }  // Added to match the form
        public string? Category { get; set; }
        public string? Tags { get; set; }
        public string? FilePath { get; set; }

        // Upload timestamp
        public DateTime UploadDate { get; set; }
    }
}
