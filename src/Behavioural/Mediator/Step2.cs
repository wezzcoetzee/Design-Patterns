namespace Mediator;

public class FlightReservationMediator : IFlightReservationMediator
{
    private readonly FlightSearchEngine _flightSearchEngine;
    private readonly PassengerInformation _passengerInformation;
    private readonly PaymentGateway _paymentGateway;
    private readonly EmailNotification _emailNotification;

    public FlightReservationMediator(
        FlightSearchEngine flightSearchEngine,
        PassengerInformation passengerInformation,
        PaymentGateway paymentGateway,
        EmailNotification emailNotification)
    {
        _flightSearchEngine = flightSearchEngine;
        _flightSearchEngine.SetMediator(this);

        _passengerInformation = passengerInformation;
        _passengerInformation.SetMediator(this);

        _paymentGateway = paymentGateway;
        _paymentGateway.SetMediator(this);

        _emailNotification = emailNotification;
        _emailNotification.SetMediator(this);
    }

    public void Notify(object sender, string eventMessage)
    {
        switch (sender)
        {
            case FlightSearchEngine:
                // Handle the event from FlightSearchEngine
                break;
            case PassengerInformation:
                // Handle the event from PassengerInformation
                break;
            case PaymentGateway:
                // Handle the event from PaymentGateway
                break;
            case EmailNotification:
                // Handle the event from EmailNotification
                break;
        }
    }
}