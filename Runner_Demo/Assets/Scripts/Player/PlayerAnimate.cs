using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimate : MonoBehaviour
{
    private Animation Anim;

    private void Start(){
        Anim = gameObject.GetComponent<Animation>();
    }

    public void ChangeAnimation(Lib State){
        if (State == Lib.STOP || State == Lib.WIN){
            Anim.Play("Idle");
        }
        else{
            Anim.Play("Run");
        }
    }
}
