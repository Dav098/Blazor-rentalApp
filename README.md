# 🚗 Blazor RentalApp

![Blazor](https://img.shields.io/badge/Web-Blazor%20WebAssembly%20%2F%20Server-512BD4?style=for-the-badge&logo=.net&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?style=for-the-badge&logo=.net&logoColor=white)
![License](https://img.shields.io/badge/License-MIT-green?style=for-the-badge)

**Blazor RentalApp** is a modern web application designed to manage rental processes (e.g., vehicles, real estate, or equipment), built using the **Blazor** framework and the **.NET** platform. The project combines an intuitive user interface with a robust backend, ensuring smooth performance and full responsiveness.

---

## 🚀 Features

### 👤 User Panel (Client)
* **Browse Offerings:** Interactive list of available items/vehicles for rent with advanced filtering and sorting options.
* **Item Details:** Dedicated view featuring complete descriptions, image galleries, specifications, and pricing details.
* **Booking System:** Intuitive date picker (calendar) with automatic total cost calculation.
* **Order History:** Overview of active, completed, and canceled reservations.
* **User Profile:** Manage personal information, account details, and settings.

### 🔑 Admin Panel
* **Inventory Management:** Full CRUD operations (Add, Edit, Delete) for items available for rent.
* **Reservation Handling:** Approve, reject, and update the status of client bookings.
* **User Management:** View registered users and assign roles/permissions (e.g., Admin, Moderator).
* **Statistics & Reports:** A simple dashboard displaying revenue and the most popular rental items.

---

## 🛠️ Tech Stack

* **Frontend:** Blazor (WebAssembly or Server), HTML5, CSS3, Bootstrap / MudBlazor (depending on the UI library used).
* **Backend (API):** ASP.NET Core Web API (if using a client-server architecture).
* **Database:** Entity Framework Core (SQL Server / PostgreSQL / SQLite).
* **Authentication:** ASP.NET Core Identity / JWT Tokens.

---

## 📸 Screenshots

> *Place your application screenshots here. You can add them by uploading images to a folder like `screenshots/` in your repository.*

| Main Page / Catalog | Booking Panel |
| :---: | :---: |
| ![Catalog](https://via.placeholder.com/400x250?text=Product+Catalog) | ![Booking](https://via.placeholder.com/400x250?text=Booking+Form) |

---

## 💻 Getting Started

### Prerequisites
Before running the project, ensure you have the following installed:
* [.NET SDK 8.0](https://dotnet.microsoft.com/download) (or the version matching your project)
* An IDE (e.g., [Visual Studio 2022](https://visualstudio.microsoft.com/vs/), [JetBrains Rider](https://www.jetbrains.com/rider/), or [VS Code](https://code.visualstudio.com/))
* A database server (e.g., SQL Server LocalDB)

### Step-by-Step Installation

1.  **Clone the repository:**
    ```bash
    git clone [https://github.com/Dav098/Blazor-rentalApp.git](https://github.com/Dav098/Blazor-rentalApp.git)
    cd Blazor-rentalApp
    ```

2.  **Configure the Database (Entity Framework):**
    Open the `appsettings.json` file in your server/API project, update the `ConnectionString` to match your local database instance, and run the migration:
    ```bash
    dotnet ef database update
    ```

3.  **Run the Application:**
    Navigate to the root directory of the project and execute:
    ```bash
    dotnet run
    ```
    Alternatively, open the project in Visual Studio / Rider and press `F5`.

4.  **Open in Browser:**
    The application should be accessible at the address specified in the console output (usually `https://localhost:7001` or `https://localhost:5001`).

---
