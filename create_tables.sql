-- Create the Employee table to store information about restaurant employees
CREATE TABLE Employee (
    EmployeeID INT PRIMARY KEY AUTO_INCREMENT,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Username VARCHAR(50) NOT NULL UNIQUE,
    Password VARCHAR(100) NOT NULL,  -- Store hashed passwords for security
    Role VARCHAR(20) NOT NULL  -- Employee role (e.g., waiter, cashier)
);

-- Create the Menu table to store the list of menu items
CREATE TABLE Menu (
    ItemID INT PRIMARY KEY AUTO_INCREMENT,
    ItemName VARCHAR(100) NOT NULL,
    Description TEXT,
    Price DECIMAL(10, 2) NOT NULL
);

-- Create the TableAssignment table to assign tables to employees
CREATE TABLE TableAssignment (
    AssignmentID INT PRIMARY KEY AUTO_INCREMENT,
    EmployeeID INT NOT NULL,
    TableNumber INT NOT NULL,
    AssignmentDate DATE,
    FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID)
);

-- Create the TableInfo table to store information about restaurant tables
CREATE TABLE TableInfo (
    TableNumber INT PRIMARY KEY,
    Seats INT NOT NULL,
    Status VARCHAR(20) NOT NULL  -- Table status (e.g., vacant, occupied, reserved)
);

-- Create the Order table to store customer orders
CREATE TABLE Order (
    OrderID INT PRIMARY KEY AUTO_INCREMENT,
    TableNumber INT NOT NULL,
    EmployeeID INT NOT NULL,
    OrderDate DATETIME NOT NULL,
    Status VARCHAR(20) NOT NULL,  -- Order status (e.g., open, closed)
    FOREIGN KEY (TableNumber) REFERENCES TableInfo(TableNumber),
    FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID)
);

-- Create the OrderItem table to store individual items within an order
CREATE TABLE OrderItem (
    OrderItemID INT PRIMARY KEY AUTO_INCREMENT,
    OrderID INT NOT NULL,
    ItemID INT NOT NULL,
    SpecialInstructions TEXT,  -- Special order instructions (e.g., no tomatoes)
    FOREIGN KEY (OrderID) REFERENCES Order(OrderID),
    FOREIGN KEY (ItemID) REFERENCES Menu(ItemID)
);

-- Create the Invoice table to store customer invoices
CREATE TABLE Invoice (
    InvoiceID INT PRIMARY KEY AUTO_INCREMENT,
    OrderID INT NOT NULL,
    TotalAmount DECIMAL(10, 2) NOT NULL,
    PaidAmount DECIMAL(10, 2),
    InvoiceDate DATETIME NOT NULL,
    FOREIGN KEY (OrderID) REFERENCES Order(OrderID)
);

-- Create the Tip table to store tips received by employees
CREATE TABLE Tip (
    TipID INT PRIMARY KEY AUTO_INCREMENT,
    EmployeeID INT NOT NULL,
    Amount DECIMAL(10, 2) NOT NULL,
    TipDate DATE NOT NULL,
    FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID)
);

-- Create the DailyTurnover table to store daily turnover information
CREATE TABLE DailyTurnover (
    TurnoverID INT PRIMARY KEY AUTO_INCREMENT,
    EmployeeID INT NOT NULL,
    TotalTurnover DECIMAL(10, 2) NOT NULL,
    TurnoverDate DATE NOT NULL,
    FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID)
);