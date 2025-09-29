Project Title:
DocuVault – Personal & Enterprise Document Organizer
________________________________________
Project Description (Resume-Ready)
DocuVault is a C#/.NET application that allows users to securely upload, organize, and manage digital documents. Users can store files with metadata (title, category, tags, upload date) and search or filter by these fields. The project demonstrates CRUD operations, SQL Server integration, and responsive UI design with Bootstrap, while also serving as a practical tool for personal document organization.
________________________________________
Downscaled Project Outline
1. Tech Stack:
•	Backend: C# with ASP.NET Core 7 Razor Pages
•	Database: SQL Server (store file metadata)
•	Frontend: Razor Pages + Bootstrap
•	File Handling: Local file storage (files on disk, paths stored in SQL Server)
•	Version Control: Git/GitHub
________________________________________
2. Database Schema (SQL Server)
Table: Documents
Column Name	Data Type	Notes
DocumentID	INT (PK, Identity)	Unique identifier
Title	NVARCHAR(255)	Document title
Category	NVARCHAR(100)	e.g., Personal, Work, Finance
Tags	NVARCHAR(255)	Comma-separated tags
FilePath	NVARCHAR(500)	Path to file on disk
UploadDate	DATETIME	Date uploaded



3. Folder/File Structure (Simplified)
DocuVault/
│
├─ src/
│   ├─ DocuVaultApp/
│   │   ├─ Pages/
│   │   │   ├─ Index.cshtml            # List documents
│   │   │   ├─ Index.cshtml.cs
│   │   │   ├─ Upload.cshtml           # Upload form
│   │   │   ├─ Upload.cshtml.cs
│   │   │   ├─ Edit.cshtml             # Edit metadata
│   │   │   └─ Edit.cshtml.cs
│   │   ├─ Models/
│   │   │   └─ Document.cs             # Document model class
│   │   ├─ Data/
│   │   │   └─ ApplicationDbContext.cs # SQL Server DB context
│   │   └─ Program.cs                  # App setup
│
├─ wwwroot/
│   └─ uploads/                         # Folder to store uploaded files
│
├─ docs/
│   └─ README.md
│
└─ .gitignore
