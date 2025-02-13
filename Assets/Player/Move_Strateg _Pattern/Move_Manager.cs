using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Manager : MonoBehaviour
{
    
    public ThongTinCoBan ThongTinCoBan1;
    public DiChuyenCoBan diChuyenCoBan ;
    public Luot luot;
    public Nhay nhay;
    public float input ;

    public Button_Mobi_Joy button_Mobi_Joy;
    private bool May_Tinh;
    
    void Start()
    {
        diChuyenCoBan = new DiChuyenCoBan(gameObject);
        nhay = new Nhay(gameObject);
        luot = new Luot(gameObject);

        May_Tinh = false;
        if ( Application.platform == RuntimePlatform.WindowsEditor || Application.platform == RuntimePlatform.WindowsPlayer || Application.platform == RuntimePlatform.OSXPlayer)
        {
        
            May_Tinh = true;
        }


    }

    void Update()
    {
        if (May_Tinh){
            input = Input.GetAxis("Horizontal");
        }else{
            input = button_Mobi_Joy.joystick.Horizontal;
        }
        diChuyenCoBan.HanhDong_DiChuyen();
        nhay.HanhDong_DiChuyen();
        luot.HanhDong_DiChuyen();
    }
}
