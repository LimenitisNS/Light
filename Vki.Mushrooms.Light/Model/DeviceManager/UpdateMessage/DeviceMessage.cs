using System;

namespace Vki.Mushrooms.Light.Model.DeviceManager.UpdateMessage
{
    public abstract class DeviceMessage
    {
        protected DeviceMessage(Guid roomId)
        {
            RoomId = roomId;
        }

        public Guid RoomId { get; }
    }
}
