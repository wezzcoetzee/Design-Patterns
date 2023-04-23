namespace Mediator;

public class FlightSearchEngine : FlightReservationComponent
{
    public void SearchFlights()
    {
        // Search flights logic
        Mediator.Notify(this, "FlightSelected");
    }
}

public class PassengerInformation : FlightReservationComponent
{
    public void ProvidePassengerDetails()
    {
        // Collect passenger details logic
        Mediator.Notify(this, "PassengerDetailsProvided");
    }
}

public class PaymentGateway : FlightReservationComponent
{
    public void ProcessPayment()
    {
        // Process payment logic
        Mediator.Notify(this, "PaymentProcessed");
    }
}

public class EmailNotification : FlightReservationComponent
{
    public void SendConfirmationEmail()
    {
        // Send email logic
        Mediator.Notify(this, "EmailSent");
    }
}