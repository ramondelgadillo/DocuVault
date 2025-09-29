# DocuVaultApp

DocuVaultApp is a modern, secure, and user-friendly web application for managing documents. Users can upload, view, and manage their files efficiently.
---

## Table of Contents

- [Features](#features)
- [Technologies Used](#technologies-used)
- [Project Structure](#project-structure)
- [Setup and Installation](#setup-and-installation)
- [Usage](#usage)
- [Database](#database)
- [Styling](#styling)
- [Contributing](#contributing)
- [License](#license)

---

## Features

- **Secure Document Upload:** Upload documents safely to your personal vault.  
- **Recent Documents:** Quickly access your most recent uploads.  
- **Dark Mode Design:** Modern and minimalistic dark interface inspired by platforms like Spotify and YouTube.  
- **Responsive Layout:** Works seamlessly on desktops, tablets, and mobile devices.  
- **Quick Links:** Shortcut cards for frequent actions like uploading and viewing documents.  

---

## Technologies Used

- **Frontend:**  
  - ASP.NET Core Razor Pages  
  - Bootstrap 5  
  - Custom CSS for dark theme and accents  

- **Backend:**  
  - C#  
  - ASP.NET Core  
  - Entity Framework Core  
  - SQL Server (LocalDB)

- **Tools:**  
  - Visual Studio / VS Code  
  - .NET 7  
  - Git  

---

## Project Structure

    DocuVaultApp/
    │
    ├─ Pages/
    │ ├─ Index.cshtml # Homepage
    │ ├─ Documents/
    │ │ ├─ Index.cshtml # List of documents
    │ │ ├─ Index.cshtml.cs # Page model for documents
    │ │ ├─ Upload.cshtml # Document upload page
    │ │ └─ Upload.cshtml.cs # Page model for upload
    │ └─ Privacy.cshtml # Privacy page
    │
    ├─ Data/
    │ └─ ApplicationDbContext.cs # EF Core DbContext
    │
    ├─ Models/
    │ └─ Document.cs # Document model
    │
    ├─ wwwroot/
    │ ├─ css/
    │ │ └─ site.css # Custom CSS for dark theme
    │ └─ uploads/ # Folder for storing uploaded documents
    │
    ├─ Program.cs # Application entry point
    └─ DocuVaultApp.csproj # Project file


---

## Setup and Installation

1. **Clone the repository:**

   git clone https://github.com/your-username/DocuVaultApp.git
   cd DocuVaultApp


2. **Install dependencies and restore packages:**

    dotnet restore

3. **Apply database migrations (if using migrations):**

    dotnet ef database update

4. **Run the Project**

    dotnet run

5. **Open in Browser**


## Usage

- Navigate to the homepage to see a welcome message and quick links.

- Use Upload Document to add a new file.

- View Recent Documents on the homepage or use the Documents page in the navbar to see all uploaded files.

- Click the View button under each document to open it in a new tab.

## Database

  - The app uses SQL Server LocalDB by default.
  - The Document table stores:
        Id (int, primary key)
        Title (string)
        Category (string)
        FilePath (string)
        UploadDate (DateTime)

  - EF Core handles database interactions through ApplicationDbContext.

## Styling

- Dark background with subtle blue accents.

- Buttons, cards, and text inputs are styled for readability and visual hierarchy.

- Responsive layout adapts to mobile and desktop views.