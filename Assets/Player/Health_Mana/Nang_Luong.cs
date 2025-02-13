using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nang_Luong : A_Resources
{
   

     void Update()
    {
       

        Tang_Dan();
    }

    public override void DangTru()
    {
        Observer_Pattern_Sever.Instance.DKSK_Player_TakeMana(Toi_Thieu,Toi_Da,Hien_Tai);
    }

    public override void DangCong()
    {
        Observer_Pattern_Sever.Instance.DKSK_Player_TakeMana(Toi_Thieu,Toi_Da,Hien_Tai);
    }

    public override void Dat_Moc()
    {
       
    }

    public override void Het()
    {
       
    }
}
