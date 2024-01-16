using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityObservable
{
    public interface IObserver
    {
        public void NotifyUpdate<T>( ISubject subject );
    }

    public abstract class BaseObserver: IObserver
    {
        public virtual void NotifyUpdate<T>( ISubject subject )
        {

        }
    }

    public abstract class BaseMonoBehaviourObserver: MonoBehaviour, IObserver
    {
        public virtual void NotifyUpdate<T>( ISubject subject )
        {

        }
    }
}
