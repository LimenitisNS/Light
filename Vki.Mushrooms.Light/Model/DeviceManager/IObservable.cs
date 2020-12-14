using Vki.Mushrooms.Light.Model.DeviceManager.UpdateMessage;

namespace Vki.Mushrooms.Light.Model.DeviceManager
{
    public interface IObservable
    {
        void AddObserver(ILampObserver lampObserver);
        void RemoveObserver(ILampObserver lampObserver);
        void NotifyObservers(DeviceMessage type);
    }
}
