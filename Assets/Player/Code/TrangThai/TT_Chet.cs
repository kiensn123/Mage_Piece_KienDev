using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Cinemachine;
using JetBrains.Annotations;
using UnityEngine;

public class TT_Chet :  A_TrangThai
{



    public  void BatDau_TrangThai(TrangThai_Manager trangThai_Manager)
    {
        
        trangThai_Manager.HienThi_TrangThai = "Chet";
        trangThai_Manager.gameObject.GetComponent<Move_Manager>().luot.DuocLuot = false;
        trangThai_Manager.gameObject.GetComponent<Move_Manager>().diChuyenCoBan.DuocDiChuyen = false;
        trangThai_Manager.gameObject.GetComponent<Move_Manager>().nhay.DuocNhay = false;
        // Lưu FOV gốc

        Observer_Pattern_Sever.Instance.DKSK_Player_Die(trangThai_Manager.gameObject);
    
        
    }

    // IEnumerator ChuyenSangHoiSinh(){
    //     yield return new wai
    // }

   

    public void CapNhat_TrangThai(TrangThai_Manager trangThai_Manager)
    {
        
    }

    public  void Ketthuc_TrangThai(TrangThai_Manager trangThai_Manager)
    {
        // trangThai_Manager.gameObject.GetComponent<Move_Manager>().diChuyenCoBan.DuocDiChuyen = true;
        // trangThai_Manager.gameObject.GetComponent<Move_Manager>().luot.DuocLuot = true;
        // trangThai_Manager.gameObject.GetComponent<Move_Manager>().nhay.DuocNhay = true;
    }

    
}
