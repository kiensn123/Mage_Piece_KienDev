using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrangThai_Manager : MonoBehaviour
{
    
    A_TrangThai a_TrangThai;

    public string HienThi_TrangThai;

    
    public TT_BinhThuong tT_BinhThuong = new TT_BinhThuong();
    public TT_Choang tT_Choang = new TT_Choang();
    public TT_Chet tT_Chet = new TT_Chet();
    public TT_HoiSinh tT_HoiSinh = new TT_HoiSinh();

    void Start()
    {
        a_TrangThai = tT_BinhThuong;
        a_TrangThai.BatDau_TrangThai(this);
    }

    // Update is called once per frame
    void Update()
    {
        a_TrangThai.CapNhat_TrangThai(this);
    }

    public void ThayDoi_TrangThai(A_TrangThai T_TrangThai){
        a_TrangThai.Ketthuc_TrangThai(this);
        this.a_TrangThai = T_TrangThai;
        a_TrangThai.BatDau_TrangThai(this);
    }
}
