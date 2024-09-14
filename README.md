# Purchase Order Upload Demo

This project is a demo application built using **ASP.NET Core MVC**. It allows users to upload purchase order files (in PDF format) as part of an order completion system. The uploaded PDF file is processed and saved for future reference.

## Features

- Users can upload a purchase order in PDF format.
- The system ensures that the file is not empty before proceeding.
- The uploaded PDF is viewable after submission.
- A minimalistic form interface is used to handle uploads.

## Technologies Used

- **ASP.NET Core MVC** (.NET 7 or higher)
- **C#**
- **HTML** for the front-end
- **JavaScript** (optional, but used for client-side validation in future versions)
- **Bootstrap** (optional, for styling)

## Prerequisites

Before you begin, ensure you have met the following requirements:

- [.NET SDK 7.0 or higher](https://dotnet.microsoft.com/download)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) (or any code editor that supports .NET development)
- A web browser (Google Chrome, Firefox, etc.)

## Running the Project Locally

To run this project locally, follow these steps:

1. **Clone the repository:**

   ```bash
   git clone https://github.com/your-username/PurchaseOrderUploadDemo.git
   cd PurchaseOrderUploadDemo

   dotnet build
   dotnet run
   http://your-local-host/Order/Upload
