using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Di_Chuyen_Phai : I_Coman
{
    
    private Transform _player;
    private Vector3 _Luu_Truu_Toa_Do;

    public Di_Chuyen_Phai( Transform _player)
    {
        this._player = _player;
    }

    public void Huy()
    {
       _player.position = _Luu_Truu_Toa_Do;
    }

    public void ThucHien()
    {
        _Luu_Truu_Toa_Do = _player.position;
        _player.position += Vector3.right;

    }
}
