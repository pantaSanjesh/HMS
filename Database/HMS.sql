-- 1. Create database
CREATE DATABASE HotelDB;
GO
USE HotelDB;
GO

-- 2. Guests
CREATE TABLE Guests (
    GuestID INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Gender NVARCHAR(10),
    Address NVARCHAR(200),
    PhoneNumber NVARCHAR(20),
    Email NVARCHAR(100)
);

-- 3. Rooms
CREATE TABLE Rooms (
    RoomID INT IDENTITY(1,1) PRIMARY KEY,
    RoomNumber NVARCHAR(10) NOT NULL,
    RoomType NVARCHAR(50)
);

-- 4. Bookings
CREATE TABLE Bookings (
    BookingID INT IDENTITY(1,1) PRIMARY KEY,
    GuestID INT NOT NULL FOREIGN KEY REFERENCES Guests(GuestID),
    RoomID INT NOT NULL FOREIGN KEY REFERENCES Rooms(RoomID),
    CheckInDate DATE,
    CheckOutDate DATE,
    BookingStatus NVARCHAR(50),
    Remarks NVARCHAR(200),
    PaymentMode NVARCHAR(50)
);

-- 5. Services (many per booking)
CREATE TABLE Services (
    ServiceID INT IDENTITY(1,1) PRIMARY KEY,
    BookingID INT NOT NULL FOREIGN KEY REFERENCES Bookings(BookingID),
    ServiceName NVARCHAR(100),
    ServiceCost DECIMAL(10,2)
);

-- 6. Users (for login)
CREATE TABLE Users (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50) UNIQUE NOT NULL,
    PasswordHash NVARCHAR(255) NOT NULL,
    Role NVARCHAR(20) NOT NULL -- Admin / Receptionist
);

-- 7. Seed sample rooms and an admin user
INSERT INTO Rooms (RoomNumber, RoomType) VALUES ('201','Single'),('203','Double'),('204','Standard'),('208','Deluxe');

-- Helper: compute sha256 hash of admin@123 externally or below using SQL CLR; 
-- For simplicity we insert the precomputed SHA256 of "admin@123":
-- SHA256("admin@123") = "a6e4a8ccf4bb2d9b2a2cb2d5d17ae8bce7cc19a2c5ffa7c48613a8a0f8a22614"
INSERT INTO Users (Username, PasswordHash, Role) VALUES ('admin','a6e4a8ccf4bb2d9b2a2cb2d5d17ae8bce7cc19a2c5ffa7c48613a8a0f8a22614','Admin');

GO
