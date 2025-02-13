using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSpawPoint : MonoBehaviour
{

    private static SetSpawPoint instance;

    public static SetSpawPoint Instance
    {
        get{
            if (instance == null){
                instance = FindObjectOfType<SetSpawPoint>();
                if (instance == null){
                     GameObject singletonObject = new GameObject(typeof(SetSpawPoint).Name);
                    instance = singletonObject.AddComponent<SetSpawPoint>();
                }
            }
            return instance;
        }



    }
    private void Awake() {
        if (instance != null && instance!= this){
            Destroy(gameObject);
            return;
        }

        instance = this;      
    }





    public Transform Spaw_Point;
    public void Set_SpawPoint(Transform spawpoin){
        Spaw_Point = spawpoin;
    }
}
