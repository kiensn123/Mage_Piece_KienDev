using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mau :  A_Resources 
{
 
    private Animator animator;

    private TrangThai_Manager trangThai_Manager1;

    

    void Start()
    {
       
        animator = gameObject.GetComponentInChildren<Animator>();
        trangThai_Manager1 = gameObject.GetComponent<TrangThai_Manager>();
        animator.SetFloat("Health",Hien_Tai);
    }

    
    void Update()
    {
        if (Hien_Tai<0.1)
        {
            return;
        }

        Tang_Dan();
    }

    public override void Dat_Moc()
    {
        
    }

    public override void Het()
    {
        
        TrangThai_Manager trangThai_Manager = gameObject.GetComponent<TrangThai_Manager>();
        // trangThai_Manager.ThayDoi_TrangThai(trangThai_Manager.tT_Chet);
    }   

    public override void DangCong()
    {
       animator.SetFloat("Health",Hien_Tai);
       Observer_Pattern_Sever.Instance.DKSK_Player_TakeDamage(Toi_Thieu,Toi_Da,Hien_Tai);




    }

    public override void DangTru()
    {
        animator.SetFloat("Health",Hien_Tai);
        Observer_Pattern_Sever.Instance.DKSK_Player_TakeDamage(Toi_Thieu,Toi_Da,Hien_Tai);


        GameObject Art = gameObject.transform.Find("Art")?.gameObject;
        GameObject Char = Art.transform.GetChild(0).gameObject;
        Observer_Pattern_Sever.Instance.DKSK_Flash_Damge(0.1f,1,Color.red,Char);

    }
}
