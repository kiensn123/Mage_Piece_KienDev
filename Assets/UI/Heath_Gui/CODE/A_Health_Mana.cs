using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public abstract class A_Health_Mana : MonoBehaviour
{
    protected  GameObject Noi_Nang;
    protected Slider slider;

  

    private void Start() {
        Noi_Nang = gameObject;
        slider = Noi_Nang.GetComponent<Slider>();
      
    }


    public void CapNhatTheo_PhanTram(float toithieu , float toida,float hientai){
        DOTween.To(()=> 
        slider.value,x=>slider.value = x
        ,hientai/toida,0.2f);

  
        //  DOTween.To(() => slider.value, x => slider.value = x, toithieu / toida, 0.2f);
        // slider.value = hientai/toida;
    }

    private void OnDisable() {
        Huy_Obsever();
    }

    private void OnEnable() {
        KetNoi_Obsever();
    }


    public abstract void KetNoi_Obsever(); 
    public abstract void Huy_Obsever(); 
}
