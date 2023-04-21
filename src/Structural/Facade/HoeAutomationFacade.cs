namespace Facade;

public class HomeAutomationFacade
{
    private readonly Lights _lights;
    private readonly Heating _heating;
    private readonly Security _security;

    public HomeAutomationFacade(Lights lights, Heating heating, Security security)
    {
        _lights = lights;
        _heating = heating;
        _security = security;
    }

    public void ArriveHome()
    {
        Security.Disarm();
        Lights.On();
        _heating.SetTemperature(22);
    }

    public void LeaveHome()
    {
        Lights.Off();
        _heating.SetTemperature(18);
        Security.Arm();
    }
}