using System;
using System.Runtime.CompilerServices;

namespace Vki.Mushrooms.Light.Model.Observer
{
    public class Lamp
    {
        public bool IsStateCalm { get; private set; } = true; //покой true или тревога false - состояние лампочки
        public bool IsTurnedOn { get; private set; } = false; // включен свет - true или выключен свет - false 
        public bool IsAuto { get; private set; } = true; // режим автоматический - true или ручной - false
        
        public void SwitchState()
        {
            IsStateCalm = !IsStateCalm;
        }

        public void SwitchMode()
        {
            if (IsStateCalm)
            {
                IsAuto = !IsAuto;
            }
        }

        public void SwitchLight()
        {
            if (IsStateCalm)
            {
                IsTurnedOn = !IsTurnedOn;
            }
        }
    }
}
