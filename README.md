# 🛒 Shop Management System

A Desktop-Based Shop Management System developed using **C# Windows Forms** and **Microsoft SQL Server**. This application helps manage shop products, employee activities, sales transactions, and invoices through separate Admin and Employee dashboards.

## 📌 Project Overview

The Shop Management System is designed to simplify daily shop operations. It provides role-based login access for Admin and Employees, product management functionality, sales processing, and invoice generation.

The system uses a SQL Server database to store and retrieve product and sales information.

## ✨ Features

### 🔐 1. Login System
- Secure login interface.
- Role-based authentication.
- Separate dashboards for Admin and Employees.
- Login validation using username and password.

### 👨‍💼 2. Admin Dashboard
- View all available products.
- View sales records.
- Access product and sales information.
- Manage shop operations through the Admin interface.

### 👩‍💻 3. Employee Dashboard
- View the available product list.
- Access the sales dashboard.
- Process customer purchases.
- Navigate between employee operations.

### 📦 4. Product Management
- Add new products.
- Update existing product information.
- Delete products.
- View product details.
- Manage product name, category, price, stock, and quantity.

### 🛍️ 5. Sales Management
- Select products for purchase.
- Enter product quantities.
- Add products to the shopping cart.
- Calculate individual product totals.
- Calculate the overall purchase amount.
- Validate available stock before completing a sale.
- Save sales transactions and their details.

### 🧾 6. Invoice Generation
- Generate invoices after sales.
- Display invoice number and date.
- Show product names, quantities, prices, and totals.
- Calculate the final payable amount.
- Print invoices using the print preview functionality.

## 🛠️ Technologies Used

| Technology | Purpose |
|---|---|
| C# | Application development |
| Windows Forms | Graphical User Interface |
| .NET Framework 4.7.2 | Application framework |
| Microsoft SQL Server | Database management |
| ADO.NET | Database connectivity |
| Visual Studio | Development environment |

## 🗄️ Database

**Database Name:** `S_ManagemntDB`

The application uses Microsoft SQL Server LocalDB for database connectivity.

Main database tables referenced in the application:

- `Users` – Stores login credentials and user roles.
- `Products` – Stores product information, prices, categories, stock, and quantities.
- `Sales` – Stores sales transaction information.
- `SaleDetails` – Stores individual product details for each sale.

## 📂 Project Structure

```text
ShopManagementSystem/
│
├── ShopManagementSystem.sln
│
└── ShopManagementSystem/
    │
    ├── LoginForm.cs
    ├── AdminClass.cs
    ├── EmployeeClass.cs
    ├── Product.cs
    ├── Sale.cs
    │
    ├── Properties/
    │   ├── AdminDashboard.cs
    │   ├── EmployeeDashboard.cs
    │   ├── ProductClass.cs
    │   ├── SaleDashboard.cs
    │   ├── SaleHistory.cs
    │   ├── InvoiceForm.cs
    │   └── Resources.resx
    │
    └── App.config
```

## ⚙️ Installation & Setup

Follow these steps to run the project locally:

1. Clone the repository:

   ```bash
   git clone YOUR_REPOSITORY_URL
   ```

2. Open the `ShopManagementSystem.sln` file using Microsoft Visual Studio.

3. Make sure the following are installed:
   - Visual Studio
   - .NET Framework 4.7.2 Developer Pack
   - SQL Server LocalDB

4. Create the SQL Server database named `S_ManagemntDB`.

5. Create the required database tables (`Users`, `Products`, `Sales`, and `SaleDetails`) with columns matching the application queries.

6. Configure the database connection string if your SQL Server instance or database name is different.

7. Build and run the project.

## 🎯 Project Objective

The main objective of this project is to develop a simple and user-friendly desktop application that helps shop owners and employees manage daily shop activities efficiently. It demonstrates practical implementation of C#, Windows Forms, database connectivity, CRUD operations, role-based access, and sales transaction processing.

## 👩‍💻 Developer

Developed as a C# Desktop Application Project.

---

⭐ If you find this project interesting, feel free to explore the repository!
