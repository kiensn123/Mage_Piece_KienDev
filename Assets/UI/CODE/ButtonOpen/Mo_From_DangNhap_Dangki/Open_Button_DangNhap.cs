using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Open_Button_DangNhap : MonoBehaviour
{
    [Header("Ẩn Hiện PreFab")]
    public Button button;
    public GameObject Hien_Obj;
    public GameObject An_Obj;


    void Start()
    
    {
     
       button.onClick.AddListener(MO_DangNhapDangKI);
    }


    public void MO_DangNhapDangKI(){

      
        if (Hien_Obj){
            Hien_Obj.SetActive(true);
        }
        if (An_Obj){
            An_Obj.SetActive(false);
        }
        Dieu_KienTiep();
    }
    public abstract void Dieu_KienTiep();
}
