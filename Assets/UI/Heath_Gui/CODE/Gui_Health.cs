using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gui_Health : A_Health_Mana
{



    public override void Huy_Obsever()
    {
             Observer_Pattern_Sever.Instance.Player_TakeDamage -= CapNhatTheo_PhanTram;
    }

    public override void KetNoi_Obsever()
    {
            Observer_Pattern_Sever.Instance.Player_TakeDamage += CapNhatTheo_PhanTram;
    }
}
