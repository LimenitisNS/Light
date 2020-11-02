using System;
using System.Runtime.CompilerServices;

public class Lamp : IObserver
{
    private bool State = true;  //покой true или тревога false
    private bool Light = false; // вкл true или выкл false
    private bool Mode = true; // авто true или ручной false

    public void TurnLightOn()
    {
        this.Light = true;
    }

    public void TurnLightOff()
    {
        this.Light = false;
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
        this.Mode = true;
    }

    public void EnableManual()
    {
        this.Mode = false;
    }

    public void Update()
    {

    }
}
