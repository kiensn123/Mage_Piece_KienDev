using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observer_Pattern_Sever : MonoBehaviour
{
    private static Observer_Pattern_Sever instance;

    public static Observer_Pattern_Sever Instance
    {
        get{
            if (instance == null){
                instance = FindObjectOfType<Observer_Pattern_Sever>();
                if (instance == null){
                     GameObject singletonObject = new GameObject(typeof(Observer_Pattern_Sever).Name);
                    instance = singletonObject.AddComponent<Observer_Pattern_Sever>();
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

    /// <summary>
    /// HieuUngKhiNguoiChoiChet
    /// </summary>
    public  event Action<GameObject> Player_Die;

    public void DKSK_Player_Die(GameObject player){
        Player_Die?.Invoke(player);

    }

    /// <summary>
    /// Hieu Ung Khi Nguoi Choi Dash
    /// </summary>
    public  event Action<float,float> Player_Dash;


    public void DKSK_Player_Dash(float lucSkake,float time){
        Player_Dash?.Invoke(lucSkake,time);

    }

    /// <summary>
    /// Hieu Ung Khi Nguoi Choi Bi Dinh Dam
    /// </summary>
    public event Action<float,float,float> Player_TakeDamage;


    public void DKSK_Player_TakeDamage(float toithieu , float toida , float hientai){
        Player_TakeDamage?.Invoke(toithieu,toida,hientai);
    }
    /// <summary>
    ///  Hieu Ung Khi Nguoi Choi Su Dung Mana
    /// </summary>
    public event Action<float,float,float> Player_TakeMana;
     public void DKSK_Player_TakeMana(float toithieu , float toida , float hientai){
        Player_TakeMana?.Invoke(toithieu,toida,hientai);
    }
    


    //HieuUngAnhSang
    public event Action<float,float,Color,GameObject> Flash_Damge;

   
    /// <param name="thoigian">Thời Gian Ánh Sáng Trắng Hoạt động</param>
    /// <param name="mausac">Màu Sắc Của Ánh Sáng</param>
    /// <param name="do_dam">Độ Đậm Nhạt của Ánh Sáng</param>
    public void DKSK_Flash_Damge(float thoigian , float do_dam ,Color mausac ,GameObject character){
        Flash_Damge?.Invoke(thoigian,do_dam,mausac,character);
    }
    


    ///HieuUngNguoiChoiHoiSinh
    
    public event Action<GameObject> Player_HoiSinh;


    /// <param name="plr">Người Chơi</param>
    public void DKSK_Player_HoiSinh(GameObject plr){
        Player_HoiSinh?.Invoke(plr);
    }

    
}
