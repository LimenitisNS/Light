using System;

namespace Vki.Mushrooms.Light.Model.DeviceManager.UpdateMessage
{
    public class AlertStateMessage : DeviceMessage
    {
        public AlertStateMessage(Guid roomId) : base(roomId)
        {
        }
    }
}
