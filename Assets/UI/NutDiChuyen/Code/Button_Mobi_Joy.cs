using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Mobi_Joy : MonoBehaviour
{

    public FixedJoystick joystick;



   
    private void Start() {
      
        Debug.Log(Application.platform);
        if (Application.platform == RuntimePlatform.WindowsEditor || Application.platform == RuntimePlatform.WindowsPlayer || Application.platform == RuntimePlatform.OSXPlayer )
        {
            Destroy(gameObject);
        }else{
            joystick.gameObject.SetActive(true);
        }

    }

   
}
