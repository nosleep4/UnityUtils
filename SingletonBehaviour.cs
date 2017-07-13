using UnityEngine;
using System.Collections;

public class SingletonBehaviour<T> : MonoBehaviour where T : Object
{
    static T instance;

    public static T Instance
    { 
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType(typeof(T)) as T;
            }
            return instance;
        }
    }
    protected SingletonBehaviour(){}
}