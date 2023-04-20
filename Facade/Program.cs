using Facade;

var lights = new Lights();
var heating = new Heating();
var security = new Security();

var facade = new HomeAutomationFacade(lights, heating, security);

facade.ArriveHome();
Console.WriteLine("---");
facade.LeaveHome();