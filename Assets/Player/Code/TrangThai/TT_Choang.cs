using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TT_Choang : A_TrangThai
{


    public  void BatDau_TrangThai(TrangThai_Manager trangThai_Manager)
    {
        trangThai_Manager.HienThi_TrangThai = "Choang";
        // trangThai_Manager.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
      

        trangThai_Manager.gameObject.GetComponent<Move_Manager>().luot.DuocLuot = false;
        trangThai_Manager.gameObject.GetComponent<Move_Manager>().diChuyenCoBan.DuocDiChuyen = false;
         trangThai_Manager.gameObject.GetComponent<Move_Manager>().nhay.DuocNhay = false;
    }

    public  void CapNhat_TrangThai(TrangThai_Manager trangThai_Manager)
    {
        
    }

    public  void Ketthuc_TrangThai(TrangThai_Manager trangThai_Manager)
    {
        trangThai_Manager.gameObject.GetComponent<Move_Manager>().diChuyenCoBan.DuocDiChuyen = true;
        trangThai_Manager.gameObject.GetComponent<Move_Manager>().luot.DuocLuot = true;
        trangThai_Manager.gameObject.GetComponent<Move_Manager>().nhay.DuocNhay = true;
    }

    


   
}
