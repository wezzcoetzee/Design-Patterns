using ChainOfResponsibility;

Approver manager = new Manager();
Approver director = new Director();
Approver ceo = new CEO();

manager.SetSuccessor(director);
director.SetSuccessor(ceo);

var p1 = new Purchase { PurchaseNumber = 1, Amount = 250.0, Purpose = "Office supplies" };
var p2 = new Purchase { PurchaseNumber = 2, Amount = 1500.0, Purpose = "Laptop" };
var p3 = new Purchase { PurchaseNumber = 3, Amount = 7500.0, Purpose = "Server" };
var p4 = new Purchase { PurchaseNumber = 4, Amount = 20000.0, Purpose = "Office renovation" };

manager.HandleRequest(p1);
manager.HandleRequest(p2);
manager.HandleRequest(p3);
manager.HandleRequest(p4);

Console.ReadKey();