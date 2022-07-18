using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody rb;
    private Transform tr;
    private Lib State = Lib.STOP;
    private float MinX, MaxX, OnStartMoveMousePosX;
    [SerializeField]private float Speed, DistanceOfMouse;
    [SerializeField]private GameObject MinX_left, MaxX_right;

    [HideInInspector]public float offset;

    private void Start(){
        rb = gameObject.GetComponent<Rigidbody>();
        tr = gameObject.GetComponent<Transform>();
        MinX = MinX_left.transform.position.x;
        MaxX = MaxX_right.transform.position.x; 
    }

    public void StateStatus(Lib St){
        
        State = St;
    }

    private void FixedUpdate(){
        if (State == Lib.START){
            float PlayerPosX = gameObject.transform.position.x;

            OnStartMoveMousePosX = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,0,DistanceOfMouse)).x;

            offset = PlayerPosX - OnStartMoveMousePosX;
        }
        else if (State == Lib.PROCESS && offset != 0){
            GoZ();

            float newPositionX = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,0,DistanceOfMouse)).x;
            float CurrentPosX = tr.position.x;
            if (CurrentPosX  <= MinX && (newPositionX + offset) > MinX ||
                (CurrentPosX  >= MaxX && (newPositionX + offset) < MaxX) ||
                (MinX < CurrentPosX  && CurrentPosX < MaxX))
                    GoHorizontal(new Vector3 ((newPositionX + offset),0,tr.position.z));
        }
        else if (State == Lib.STOP){
            offset = 0;
        }
    }

    private void GoHorizontal(Vector3 NewPosition){
        transform.position = Vector3.Lerp(transform.position,NewPosition,0.125f);
    }

    private void GoZ(){
        tr.Translate(Vector3.forward * Speed * Time.deltaTime);
    }

}