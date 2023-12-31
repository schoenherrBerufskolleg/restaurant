SQLite format 3   @                 2                                                  -�
   �    ���                                                                        �w�UtableTipTipCREATE TABLE Tip (
    TipID INTEGER PRIMARY KEY AUTOINCREMENT,
    EmployeeID INTEGER NOT NULL,
  �E�]tableMenuItemMenuItemCREATE TABLE MenuItem (
    ItemID INTEGER PRIMARY KEY AUTOINCREMENT,
    ItemName VARCHAR(100) NOT NULL,
    Description TEXT,
    Price DECIMAL(10, 2) NOT NULL
)�t�;tableEmployeeEmployeeCREATE TABLE Employee (
    EmployeeID INTEGER PRIMARY KEY AUTOINCREMENT,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Username VARCHAR(50) NOT NULL UNIQUE,
    Password VARCHAR(100) NOT NULL,  -- Store hashed passwords for security
    Role VARCHAR(20) NOT NULL  -- Employee role (e.g., waiter, cashier)
)/C indexsqlite_autoindex_Employee_1Employee   P++Ytablesqlite_sequencesqlite_sequenceCREATE TABLE sqlite_seq      	
      � ��                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 ' !BenSchönherrTrickserotestWaiter( MaikBösertNova Manetest123Waiter
   � ��   
         
      	                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 Tricksero	Nova Mane   � ���                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            (Wsqlitebrowser_rename_cTableInfoMenuItemEmployee   � ��H���                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       5 UWeinEin Wein Empfohlen von unserem Hause@       WasserStandart?�      ' 5SpriteGekühlter Softdrink@      * 5Coca ColaGekühlter Softdrink@      5 SSalatGemischter Salat mit leckerer Soße@      ) ASchnitzelPaniertes Wiener Schnitzel" 3SpaghettiSpaghetti Bolognese
0 IPizzaPizza Margherita vom Steinofen@'                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    �   �y: �     �++�stableTableAssignmentTableAssignmentCREATE TABLE TableAssignment (
    AssignmentID INTEGER PRIMARY KEY AUTOINCREMENT,
    EmployeeID INTEGER NOT NULL,
    TableNumber INTEGER NOT NULL,
    AssignmentDate DATE,
    FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID)
)�E�]tableMenuItemMenuItemCREATE TABLE MenuItem (
    ItemID INTEGER PRIMARY KEY AUTOINCREMENT,
    ItemName VARCHAR(100) NOT NULL,
    Description TEXT,
    Price DECIMAL(10, 2) NOT NULL
)�t�;tableEmployeeEmployeeCREATE TABLE Employee (
    EmployeeID INTEGER PRIMARY KEY AUTOINCREMENT,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Username VARCHAR(50) NOT NULL UNIQUE,
    Password VARCHAR(100) NOT NULL,  -- Store hashed passwords for security
    Role VARCHAR(20) NOT NULL  -- Employee role (e.g., waiter, cashier)
)/C indexsqlite_autoindex_Employee_1Employee   P++Ytablesqlite_sequencesqlite_sequenceCREATE TABLE sqlite_sequence(name,seq)        ��� �                                                                                                                                                                              �w�UtableTipTipCREATE TABLE Tip (
    TipID INTEGER PRIMARY KEY AUTOINCREMENT,
    EmployeeID INTEGER NOT NULL,
    Amount DECIMAL(10, 2) NOT NULL,
    TipDate DATE NOT NULL,
    FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID)
)�R�stableTableInfoTableInfo	CREATE TABLE TableInfo (
    TableNumber INTEGER PRIMARY KEY,
    Seats INTEGER NOT NULL,
    Status VARCHAR(20) NOT NULL  -- Table status (e.g., vacant, occupied, reserved)
)�++�stableTableAssignmentTableAssignmentCREATE TABLE TableAssignment (
    AssignmentID INTEGER PRIMARY KEY AUTOINCREMENT,
    EmployeeID INTEGER NOT NULL,
    TableNumber INTEGER NOT NULL,
    AssignmentDate DATE,
    FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID)
)P++Ytablesqlite_sequencesqlite_sequenceCREATE TABLE sqlite_sequence(name,seq)+   �       
�q
�1tableOrderItemOrderItemCREATE TABLE OrderItem (
    OrderItemID INTEGER PRIMARY KEY AUTOINCREMENT,
    OrderID INTEGER NOT NULL,
    ItemID INTEGER NOT NULL,
    SpecialInstructions TEXT,  -- Special OrderInfo instructions (e.g., no tomatoes)
    FOREIGN KEY (OrderID) REFERENCES OrderInfo(OrderID),
    FOREIGN KEY (ItemID) REFERENCES MenuItem(ItemID)
)�	�	tableOrderInfoOrderInfo
CREATE TABLE OrderInfo (
    OrderID INTEGER PRIMARY KEY AUTOINCREMENT,
    TableNumber INTEGER NOT NULL,
    EmployeeID INTEGER NOT NULL,
    OrderDate DATETIME NOT NULL,
    Status VARCHAR(20) NOT NULL,  -- OrderInfo status (e.g., open, closed)
    FOREIGN KEY (TableNumber) REFERENCES TableInfo(TableNumber),
    FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID)
)   ��stableTableInfoTableInfoCREATE TABLE TableInfo (
    TableNumber INTEGER PRIMARY KEY,
    Seats INTEGER NOT NULL,
    Status VARCHAR(20) NOT NULL  -- Table status (e.g., vacant, occupied, reserved)
)                  
�m
�)tableOrderItemOrderItemCREATE TABLE OrderItem (
    OrderItemID INTEGER PRIMARY KEY AUTOINCREMENT,
    OrderID INTEGER NOT NULL,
    ItemID INTEGER NOT NULL,
    SpecialInstructions TEXT,  -- Special OrderInfo instructions (e.g., no tomatoes)
    FOREIGN KEY (OrderID) REFERENCES OrderInfo(OrderID),
    FOREIGN KEY (ItemID) REFERENCES Menu(ItemID)
)  u�	tableOrderInfoOrderInfoCREATE TABLE OrderInfo (
    OrderID INTEGER PRIMARY KEY AUTOINCREMENT,
    TableNumber INTEGER NOT NULL,
    EmployeeID INTEGER NOT NULL,
    OrderDate DATETIME NOT NULL,
    Status VARCHAR(20) NOT NULL,  -- OrderInfo status (e.g., open, closed)
    FOREIGN KEY (TableNumber) REFERENCES TableInfo(TableNumber),
    FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID)
)   ��stableTableInfoTableInfo	CREATE TABLE TableInfo (
    TableNumber INTEGER PRIMARY KEY,
    Seats INTEGER NOT NULL,
    Status VARCHAR(20) NOT NULL  -- Table status (e.g., vacant, occupied, reserved)
)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               � �� � �                                                                                                                                                           �&''�tableDailyTurnoverDailyTurnoverCREATE TABLE DailyTurnover (
    TurnoverID INTEGER PRIMARY KEY AUTOINCREMENT,
    EmployeeID INTEGER NOT NULL,
    TotalTurnover DECIMAL(10, 2) NOT NULL,
    TurnoverDate DATE NOT NULL,
    FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID)
)�w�UtableTipTipCREATE TABLE Tip (
    TipID INTEGER PRIMARY KEY AUTOINCREMENT,
    EmployeeID INTEGER NOT NULL,
    Amount DECIMAL(10, 2) NOT NULL,
    TipDate DATE NOT NULL,
    FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID)
)�,�/tableInvoiceInvoiceCREATE TABLE Invoice (
    InvoiceID INTEGER PRIMARY KEY AUTOINCREMENT,
    OrderID INTEGER NOT NULL,
    TotalAmount DECIMAL(10, 2) NOT NULL,
    PaidAmount DECIMAL(10, 2),
    InvoiceDate DATETIME NOT NULL,
    FOREIGN KEY (OrderID) REFERENCES OrderInfo(OrderID)
)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   
   
   
            	                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              W �������xgVE4#�������yhW                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              !unoccupied !unoccupied !unoccupied !unoccupied !unoccupied !unoccupied !unoccupied !unoccupied !unoccupied !unoccupied !unoccupied !unoccupied !unoccupied !unoccupied !unoccupied
 !unoccupied	 !unoccupied !unoccupied !unoccupied !unoccupied !unoccupied !unoccupied !unoccupied !unoccupied !unoccupied   - �-                                                                                                                                                                                                                                                                                                                                                                                                                                                                             �{WW�Utablesqlitebrowser_rename_column_new_tablesqlitebrowser_rename_column_new_�'�tableTableInfoTableInfoCREATE TABLE "TableInfo" (
	`TableNumber`	INTEGER PRIMARY KEY AUTOINCREMENT,
	`Seats`	INTEGER NOT NULL,
	`Status`	VARCHAR(20) NOT NULL
)�&''�tableDailyTurnoverDailyTurnoverCREATE TABLE DailyTurnover (
    TurnoverID INTEGER PRIMARY KEY AUTOINCREMENT,
    EmployeeID INTEGER NOT NULL,
    TotalTurnover DECIMAL(10, 2) NOT NULL,
    TurnoverDate DATE NOT NULL,
    FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID)
)