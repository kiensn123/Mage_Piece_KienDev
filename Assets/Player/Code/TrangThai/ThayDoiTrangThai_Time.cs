using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThayDoiTrangThai_Time : MonoBehaviour
{
    TrangThai_Manager trangThai_Manager ;
    private float ThoiGian;
    private bool DangChoang;



   
   private void Start() {
        trangThai_Manager = gameObject.GetComponent<TrangThai_Manager>();
   }

 
    private void Update() {
        if (ThoiGian > 0) {
            BatDauChoang();
            ThoiGian -= Time.deltaTime;
        } else {
            KetThucChoang();
            
        }
    }

    private void BatDauChoang() {
        if (!DangChoang) {
            DangChoang = true;
            trangThai_Manager.ThayDoi_TrangThai(trangThai_Manager.tT_Choang);
        }
    }

    private void KetThucChoang() {
        if (DangChoang) {
            DangChoang = false;
            trangThai_Manager.ThayDoi_TrangThai(trangThai_Manager.tT_BinhThuong);
            ThoiGian = 0;
        }
    }


    public void ThemThoiGianChoang(float thoigian){
        this.ThoiGian += thoigian;
    }
}
