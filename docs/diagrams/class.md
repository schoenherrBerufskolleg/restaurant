@startuml EmployeeManagementSystem

!define Table class
!define PrimaryKey {field} PRIMARY KEY
!define ForeignKey {field} FOREIGN KEY

Table Employee {
  {field} +int EmployeeID 
  {field} +string FirstName 
  {field} +string LastName 
  {field} +string Username 
  {field} +string Password 
  {field} +string Role 
  {method} +List[Dict] getTips()
  {method} +void addTip()
  {method} +List[Dict] getTurnover()
  {method} +Orders getOrders()
}

Table TableAssignment {
  {field} +int AssignmentID 
  {field} +int EmployeeID 
  {field} +int TableNumber 
  {field} +datetime AssignmentDate 
  {method} -Order getUnpaidOrder()
  {method} +String getTableInfo()
  {method} +void changeTable()
  {method} +void createInvoice()
  {method} +Order removeOrder()
  {method} +void payInvoice()
  {method} +void changeEmployee()
}

Table "Order" as Order {
  {field} +int OrderID 
  {field} +int TableNumber 
  {field} +int EmployeeID 
  {field} +datetime OrderDate 
  {field} +String Status 
  {method} +int getCurrentTableAssignment()
  {method} +List[Order] getAllOrderItems()
  {method} +OrderItem getOrderItem()
}

Table OrderItem {
  {field} +int OrderItemID 
  {field} +int OrderID 
  {field} +int ItemID 
  {field} +String SpecialInstructions
  {method} +String getMenuInfo()
  {method} +Int getPrice()
}

Employee ||--o{ TableAssignment : Manages
Employee ||--o{ "Order" : Takes
"Order" ||--o{ OrderItem : Contains
"Order" ||--|| TableAssignment : Contains
@enduml