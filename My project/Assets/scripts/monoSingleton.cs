using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
{
    private static T instance = null;
    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameObject(typeof(T).ToString(), typeof(T)).GetComponent<T>();
                instance.Init1();
            }
            return instance;
        }
    }
    public virtual void Init1() { }
    private void Awake()
    {
        if (instance == null)
        {
            instance = this as T;
                Init1();
        }
    }
}

