using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor.Callbacks;
#endif
using UnityEngine;

public class DiChuyenCoBan : I_DI_Chuyen
{

    public GameObject gameObject;// nhân vật hien tai
    public Move_Manager move_Manager;
  
    public ThongTinCoBan thongTinCoBan;
    
    public Animator animator;

    public GameObject Art;

    public Rigidbody2D rigidbody2D;

    public bool DuocDiChuyen;

    public DiChuyenCoBan(GameObject gameObject)
    {
        this.gameObject = gameObject;
        move_Manager = gameObject.GetComponent<Move_Manager>();
        thongTinCoBan = move_Manager.ThongTinCoBan1;
        animator = gameObject.GetComponentInChildren<Animator>();
        Art = gameObject.transform.Find("Art")?.gameObject;
        DuocDiChuyen = true;
        rigidbody2D = gameObject.GetComponentInChildren<Rigidbody2D>();
    }

    public void BatDau_HanhDong()
    {
      
    }

    public void HanhDong_DiChuyen()
    {
        
        if (!DuocDiChuyen){
            animator.SetBool("DiChuyen",false);
            return;
        }

        if (move_Manager.input!= 0){
            
            animator.SetBool("DiChuyen",true);

             Art.transform.rotation = move_Manager.input > 0 
            ? Quaternion.Euler(0, 0, 0) 
            : Quaternion.Euler(0, 180, 0);


       }else{
            animator.SetBool("DiChuyen",false);
       }
       
       gameObject.transform.Translate(Vector3.right * move_Manager.input * thongTinCoBan.TocDo  * Time.deltaTime);
        
        // rigidbody2D.velocity = new Vector2(move_Manager.input*thongTinCoBan.TocDo,rigidbody2D.velocity.y);
      

    }

    public void KetThuc_HanhDong()
    {
       
    }
}
