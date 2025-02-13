using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;

public class TT_HoiSinh : A_TrangThai
{



    public void BatDau_TrangThai(TrangThai_Manager trangThai_Manager)
    {
        Vector3 ToaDoSpaw =  new Vector3( SetSpawPoint.Instance.Spaw_Point.position.x,SetSpawPoint.Instance.Spaw_Point.position.y,trangThai_Manager.gameObject.transform.position.z);
        trangThai_Manager.gameObject.transform.position = ToaDoSpaw;

        Observer_Pattern_Sever.Instance.DKSK_Player_HoiSinh(trangThai_Manager.gameObject);
       
        // Mau mau = trangThai_Manager.gameObject.GetComponent<Mau>();
        // Nang_Luong nang_Luong =  trangThai_Manager.gameObject.GetComponent<Nang_Luong>();
        
        List<A_Resources> a_Resources =  trangThai_Manager.gameObject.GetComponents<A_Resources>().ToList();
        foreach (A_Resources a_Resources1 in a_Resources){
            a_Resources1.Them(a_Resources1.Toi_Da);
        }
        DelayExample(trangThai_Manager);

    }

    public async void DelayExample(TrangThai_Manager trangThai_Manager)
    {

        await Task.Delay(3000); 
        trangThai_Manager.ThayDoi_TrangThai(trangThai_Manager.tT_BinhThuong);

    }

    public void CapNhat_TrangThai(TrangThai_Manager trangThai_Manager)
    {
 
    }

    public void Ketthuc_TrangThai(TrangThai_Manager trangThai_Manager)
    {
      
    }

    
}
