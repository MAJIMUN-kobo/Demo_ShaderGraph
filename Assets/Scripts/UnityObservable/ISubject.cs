using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityObservable
{
    public interface ISubject
    {
        public List<IObserver> ObserverList { get; set; }

        public void AddObserver( IObserver observer );

        public void RemoveObserver( IObserver observer );

        public void NotifyObserver<T>();

        public void UpdateObserver();
    }


    public abstract class BaseSubject: ISubject
    {
        public List<IObserver> ObserverList { get; set; }

        public virtual void AddObserver( IObserver observer )
        {
            if( ObserverList == null ) ObserverList = new List<IObserver>();
            ObserverList.Add( observer );
        }

        public virtual void RemoveObserver( IObserver observer )
        {
            ObserverList.Remove( observer );
        }

        public virtual void NotifyObserver<T>()
        {

        }

        public virtual void UpdateObserver()
        {

        }
    }


    public abstract class BaseMonoBeheviourSubject: MonoBehaviour, ISubject
    {
        public List<IObserver> ObserverList { get; set; }

        public virtual void AddObserver( IObserver observer )
        {
            if( ObserverList == null ) ObserverList = new List<IObserver>();
            ObserverList.Add( observer );
        }

        public virtual void RemoveObserver( IObserver observer )
        {
            ObserverList.Remove( observer );
        }

        public virtual void NotifyObserver<T>()
        {

        }

        public virtual void UpdateObserver()
        {

        }
    }
}
