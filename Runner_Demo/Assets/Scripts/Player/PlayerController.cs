using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]private PlayerMove PlayerMoveScript;
    [SerializeField]private PlayerAnimate PlayerAnimateScript;
    private Lib State = Lib.STOP;
    private bool AlreadySend = false;

    private void Update(){
        if (State != Lib.WIN){
            if (Input.GetMouseButtonDown(0)){
                State = Lib.START;
                AlreadySend = false;
            }
            else if (Input.GetMouseButton(0) && State == Lib.START && PlayerMoveScript.offset !=0 ){
                State = Lib.PROCESS;
                AlreadySend = false;
            }
            else if (Input.GetMouseButtonUp(0)){
                State = Lib.STOP;
                AlreadySend = false;
            }
        }
        

        if (!AlreadySend){
                PlayerMoveScript.StateStatus(State);
                PlayerAnimateScript.ChangeAnimation(State);
                AlreadySend = true;
            }
        
    }

    public void Win(){
        State = Lib.WIN;
        AlreadySend = false;
    }
}
