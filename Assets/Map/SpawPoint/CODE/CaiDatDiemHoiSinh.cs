using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaiDatDiemHoiSinh : MonoBehaviour
{
    private bool IS_SetSpaw;

    private Animator animator;
    private void Start() {
        animator = gameObject.GetComponent<Animator>();
        animator.Play("ide");
        IS_SetSpaw = false;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player" && !IS_SetSpaw){
            IS_SetSpaw = true;
            SetSpawPoint.Instance.Set_SpawPoint(gameObject.transform.parent.transform);
          StartCoroutine(ChayAnimation_Save());
        }
    }

    IEnumerator ChayAnimation_Save(){
        animator.Play("Save");
        yield return null;
        float animationLength = animator.GetCurrentAnimatorStateInfo(0).length;
        yield return new WaitForSeconds(animationLength);
        gameObject.transform.parent.transform.localScale = new Vector3(1f,1f,-1f);
        animator.Play("ide");
        this.enabled = false;
    }
}
