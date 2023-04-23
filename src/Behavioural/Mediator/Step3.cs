namespace Mediator;

public abstract class FlightReservationComponent
{
    protected IFlightReservationMediator Mediator = null!;

    public void SetMediator(IFlightReservationMediator mediator)
    {
        Mediator = mediator;
    }
}