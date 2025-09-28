# Hotel Management System

A web-based Hotel Management System built using **ASP.NET Web Forms** with **MSSQL Database**.
The system helps manage **hotel bookings, rooms, guests, services, and staff**, along with a secure login system for administrators.

---

## Features

* 🔐 **Login System** (Admin authentication)
* 🏨 **Room Management** (Add, edit, delete, view rooms)
* 👤 **Guest Management** (Register, update, and view guest details)
* 📅 **Booking Management** (Check-in, check-out, and booking history)
* 🛎️ **Service Management** (Additional hotel services like food, laundry, etc.)
* 📊 **View Bookings & Services Report**
* ⚡ **MSSQL Database Integration**

---

## Project Structure

```
HotelManagementSystem/
│
├── App_Data/                # Database files (if using MDF file)
├── App_Code/                # Helper classes, database access
├── Pages/                   # All ASPX pages
│   ├── Login.aspx
│   ├── Dashboard.aspx
│   ├── Rooms.aspx
│   ├── Guests.aspx
│   ├── Bookings.aspx
│   ├── Services.aspx
│   ├── ViewBookings.aspx
│   └── Logout.aspx
│
├── Styles/                  # CSS files
├── Scripts/                 # JavaScript files
├── Web.config               # Configuration file
└── README.md                # Documentation
```

---

## Technologies Used

* **ASP.NET Web Forms** (.NET Framework)
* **C#** for backend logic
* **MSSQL Server** for database
* **ADO.NET** for database operations
* **HTML, CSS, JavaScript** for frontend

---

## Setup Instructions

1. Clone this repository

2. Open the solution in **Visual Studio**
3. Restore NuGet packages (if any)
4. Create a new **MSSQL Database** and run the SQL script (`/Database/HMS.sql`)
5. Update your **connection string** in `Web.config`
6. Run the project

---

## Future Enhancements

* Email/SMS notifications for booking confirmations
* Online payment integration
* Reporting & Analytics dashboard

---

