using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityObservable;
using ShaderDemo;

public class ShaderUnit: BaseSubject
{
    [SerializeField]
    public class Parameter
    {
        public ShaderGraphMaterial component;
    }

    public Transform Prefab { get; set; }
    public Parameter parameter { get; private set;}
    public Main main { get; private set; }

    public ShaderUnit( Main main, string assetPath )
    {
        this.main = main;
        this.LoadAsset( assetPath );
    }

    public override void NotifyObserver<T>()
    {
        foreach(IObserver observer in ObserverList )
        {
            observer.NotifyUpdate<T>( this );
        }

        base.NotifyObserver<T>();
    }

    public override void UpdateObserver()
    {
        NotifyObserver<ShaderUnit>();

        base.UpdateObserver();
    }

    private void LoadAsset( string assetPath )
    {
        this.Prefab = Resources.Load<GameObject>(assetPath).transform;

        parameter = new Parameter();
        parameter.component = this.Prefab.GetComponent<ShaderGraphMaterial>();

        if( !parameter.component )
            parameter.component = this.Prefab.gameObject.AddComponent<ShaderGraphMaterial>();
        
        parameter.component.Initialize( this );
    }
}
