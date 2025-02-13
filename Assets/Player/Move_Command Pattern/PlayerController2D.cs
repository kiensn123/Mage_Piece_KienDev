using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2D : MonoBehaviour
{
    private Di_Chuyen_Invoke _invoker;
    private I_Coman _moveLeftCommand;
    private I_Coman _moveRightCommand;

    void Start()
    {
        _invoker = new Di_Chuyen_Invoke();
        _moveLeftCommand = new Di_Chuyen_Trai(transform);
        _moveRightCommand = new Di_Chuyen_Phai(transform);
    }

    void Update()
    {
        // Di chuyển trái
        if (Input.GetKeyDown(KeyCode.A))
        {
            _invoker.Excute_Coman(_moveLeftCommand);
        }

        // Di chuyển phải
        if (Input.GetKeyDown(KeyCode.D))
        {
            _invoker.Excute_Coman(_moveRightCommand);
        }

        // Hoàn tác (Undo)
        if (Input.GetKeyDown(KeyCode.Z))
        {
            _invoker.Uno_Coman();   
        }
    }
}
