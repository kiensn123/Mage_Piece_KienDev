using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Di_Chuyen_Invoke : MonoBehaviour
{
   private Stack<I_Coman> _comenHistory = new Stack<I_Coman>();


   public void Excute_Coman(I_Coman i_Coman){
        i_Coman.ThucHien();
        _comenHistory.Push(i_Coman);

   }

   public void Uno_Coman(){
        if (_comenHistory.Count > 0)
        {
            var command = _comenHistory.Pop();
           command.Huy();
        }

   }
}
