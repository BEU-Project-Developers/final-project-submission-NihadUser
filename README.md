# E-Commerce WinForms Application

This project is a desktop-based e-commerce application built using **Windows Forms** and **Entity Framework**. It provides functionalities for managing products, including adding them to a basket, placing orders, and searching for products. Below is a detailed overview of the features and setup instructions.

---

## Features

### 1. **Product Management**
   - **Add Products**: Allows users to create new products with details such as name, price, image, and location.
   - **Edit Products**: Enables editing existing product details.
   - **Delete Products**: Marks products as deleted to prevent accidental removal.
   - **View Products**: Displays a list of available products in a user-friendly interface.
   - **Search Products**: Provides a search functionality to filter products by name.

### 2. **Basket Functionality**
   - Users can add products to their basket.
   - View the basket to see all added products.
   - Remove products from the basket if needed.

### 3. **Order Management**
   - Users can place orders for products in the basket.
   - View order history (optional if implemented).

### 4. **Authentication (Optional)**
   - A login feature is implemented to ensure secure access to the application.

### 5. **User-Friendly Interface**
   - The application provides a clean UI for navigating products and performing operations.

---

## Prerequisites

Before running this application, ensure you have the following:

1. **Development Tools**:
   - Visual Studio (Community, Professional, or Enterprise Edition)
   - .NET Framework (version compatible with your application)
   
2. **Database**:
   - A SQL Server instance (local or remote).

3. **Entity Framework**:
   - Entity Framework Core is used for database operations.

---

## Installation and Setup

### 1. **Clone the Repository**
   ```bash
   git clone <repository_url>
   ```

### 2. **Database Configuration**
   - Update the connection string in the `App.config` file to match your database settings:
     ```xml
     <connectionStrings>
         <add name="AppDbContext" connectionString="Server=YOUR_SERVER;Database=YOUR_DATABASE;Trusted_Connection=True;" providerName="System.Data.SqlClient" />
     </connectionStrings>
     ```

### 3. **Migrations and Database Update**
   - Run the following commands in the **Package Manager Console**:
     ```bash
     Add-Migration InitialCreate
     Update-Database
     ```
   - This will create the necessary database schema.

### 4. **Run the Application**
   - Press `F5` in Visual Studio to build and run the application.

---

## Project Structure

### 1. **Forms**
   - `HomeForm`: The main interface for displaying products and performing operations.
   - `CreateProduct`: A form for adding new products.
   - `EditProduct`: A form for editing existing products.
   - `BasketForm`: Displays products added to the basket.
   - `DetailsForm`: Shows detailed information about a selected product.

### 2. **Models**
   - `Product`: Represents a product with properties such as `Id`, `Name`, `Price`, `Image`, `DeletedAt`, etc.
   - `Basket`: Represents a user's basket.
   - `Order`: Represents orders placed by users.

### 3. **Database Context**
   - `AppDbContext`: Entity Framework context for managing database operations.

---

## Usage

1. **Adding a Product**:
   - Navigate to the "Add Product" form and fill in the product details.
   - Save to add the product to the database.

2. **Editing a Product**:
   - Click the "Edit" button for a product.
   - Modify the details and save the changes.

3. **Deleting a Product**:
   - Click the "Delete" button for a product.
   - This will mark the product as deleted.

4. **Searching for Products**:
   - Enter the product name in the search bar and click "Search".

5. **Basket and Orders**:
   - Add products to the basket using the "Add to Basket" button.
   - View the basket and place orders.

---

## Screenshots

(Add screenshots of your application to visually describe its functionality. Include images of the product list, search functionality, basket, and order forms.)

---

## Technologies Used

- **Programming Language**: C#
- **Framework**: .NET Framework / .NET Core
- **UI Library**: Windows Forms
- **Database**: SQL Server
- **ORM**: Entity Framework Core

---

## Contributing

If you want to contribute to this project:

1. Fork the repository.
2. Create a new branch for your feature/fix.
3. Commit your changes and push the branch.
4. Submit a pull request.

---

## License

This project is licensed under the [MIT License](LICENSE).

---

## Contact

For any queries or suggestions, feel free to contact:

- Email: nihadkarimovv@example.com
- GitHub: [NihadUser](https://github.com/yourprofile)

