@startuml EmployeeManagementSystem

!define Table class
!define PrimaryKey {field} PRIMARY KEY
!define ForeignKey {field} FOREIGN KEY

Table Employee {
  {field} EmployeeID INT {PrimaryKey}
  {field} FirstName VARCHAR(50) NOT NULL
  {field} LastName VARCHAR(50) NOT NULL
  {field} Username VARCHAR(50) NOT NULL {Unique}
  {field} Password VARCHAR(100) NOT NULL
  {field} Role VARCHAR(20) NOT NULL
}

Table Menu {
  {field} ItemID INT {PrimaryKey}
  {field} ItemName VARCHAR(100) NOT NULL
  {field} Description TEXT
  {field} Price DECIMAL(10, 2) NOT NULL
}

Table TableAssignment {
  {field} AssignmentID INT {PrimaryKey}
  {field} EmployeeID INT NOT NULL {ForeignKey(Employee.EmployeeID)}
  {field} TableNumber INT NOT NULL {ForeignKey(TableInfo.TableNumber)}
  {field} AssignmentDate DATE
}

Table TableInfo {
  {field} TableNumber INT {PrimaryKey}
  {field} Seats INT NOT NULL
  {field} Status VARCHAR(20) NOT NULL
}

Table "Order" as Order {
  {field} OrderID INT {PrimaryKey}
  {field} TableNumber INT NOT NULL {ForeignKey(TableInfo.TableNumber)}
  {field} EmployeeID INT NOT NULL {ForeignKey(Employee.EmployeeID)}
  {field} OrderDate DATETIME NOT NULL
  {field} Status VARCHAR(20) NOT NULL
}

Table OrderItem {
  {field} OrderItemID INT {PrimaryKey}
  {field} OrderID INT NOT NULL {ForeignKey(Order.OrderID)}
  {field} ItemID INT NOT NULL {ForeignKey(Menu.ItemID)}
  {field} SpecialInstructions TEXT
}

Table Invoice {
  {field} InvoiceID INT {PrimaryKey}
  {field} OrderID INT NOT NULL {ForeignKey(Order.OrderID)}
  {field} TotalAmount DECIMAL(10, 2) NOT NULL
  {field} PaidAmount DECIMAL(10, 2)
  {field} InvoiceDate DATETIME NOT NULL
}

Table Tip {
  {field} TipID INT {PrimaryKey}
  {field} EmployeeID INT NOT NULL {ForeignKey(Employee.EmployeeID)}
  {field} Amount DECIMAL(10, 2) NOT NULL
  {field} TipDate DATE NOT NULL
}

Table DailyTurnover {
  {field} TurnoverID INT {PrimaryKey}
  {field} EmployeeID INT NOT NULL {ForeignKey(Employee.EmployeeID)}
  {field} TotalTurnover DECIMAL(10, 2) NOT NULL
  {field} TurnoverDate DATE NOT NULL
}

TableInfo ||--o{ "Order" : Belongs
Menu }|--o{ OrderItem : Contains
TableInfo ||--o{ TableAssignment : Manages
Employee ||--o{ TableAssignment : Manages
Employee ||--o{ "Order" : Takes
"Order" }|--|{ OrderItem : Contains
"Order" }|--o| Invoice : Generates
Employee ||--o{ Tip : Receives
Employee ||--o{ DailyTurnover : Records
@enduml