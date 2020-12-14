using Vki.Mushrooms.Light.Model.DeviceManager.UpdateMessage;
using Vki.Mushrooms.Light.Model.Devices;

namespace Vki.Mushrooms.Light.Model.DeviceManager
{
    public interface ILampObserver : IDevice
    {
        void SwitchLighting(SwitchLightingMessage lightingMessage);
        void SwitchReactionMode(ReactionModeMessage message);
        void SwitchAlertState(AlertStateMessage stateMessage);
    }
}
