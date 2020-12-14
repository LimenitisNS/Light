using System;

namespace Vki.Mushrooms.Light.Model.DeviceManager.UpdateMessage
{
    public class SwitchLightingMessage : DeviceMessage
    {
        public SwitchLightingMessage(Guid roomId) : base(roomId)
        {

        }
    }
}
