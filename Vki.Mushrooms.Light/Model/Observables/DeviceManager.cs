using System.Collections.Generic;

public class DeviceManager : IObservable
{
    private List<IObserver> observers; 
                                
    public void ConcreteObservable()
    {
        observers = new List<IObserver>();
    }

    public void AddObserver(IObserver o)
    {
        observers.Add(o);
    }

    public void RemoveObserver(IObserver o)
    {
        observers.Remove(o);
    }

    public void NotifyObservers()
    {
        foreach (IObserver observer in observers)
            observer.Update();
    }
}
