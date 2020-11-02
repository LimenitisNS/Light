using System;
using System.Runtime.CompilerServices;

public class Lamp : IObserver
{
    private bool State = true;  //покой true или тревога false
    private bool Mode = false; // вкл true или выкл false
    private bool Regimen = true; // авто true или ручной false

    public void TurnLightOn()
    {
        this.Mode = true;
    }

    public void TurnLightOff()
    {
        this.Mode = false;
    }

    public void TurnOnAlarm()
    {
        this.State = false;
    }

    public void TurnOffAlarm()
    {
        this.State = true;
    }

    public void EnableAuto()
    {
        this.Regimen = true;
    }

    public void EnableManual()
    {
        this.Regimen = false;
    }

    public void Update()
    {

    }
}
