namespace Mediator;

public interface IFlightReservationMediator
{
    void Notify(object sender, string eventMessage);
}