using Mediator;

var flightSearchEngine = new FlightSearchEngine();
var passengerInformation = new PassengerInformation();
var paymentGateway = new PaymentGateway();
var emailNotification = new EmailNotification();

var mediator = new FlightReservationMediator(
    flightSearchEngine,
    passengerInformation,
    paymentGateway,
    emailNotification);

flightSearchEngine.SearchFlights();
passengerInformation.ProvidePassengerDetails();
paymentGateway.ProcessPayment();
emailNotification.SendConfirmationEmail();