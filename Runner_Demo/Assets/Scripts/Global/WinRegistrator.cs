using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinRegistrator : MonoBehaviour
{
    [SerializeField]private GameObject Win_img;

    private void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("Player")){
            other.gameObject.GetComponent<PlayerController>().Win();
            //other.gameObject.GetComponent<PlayerController>().enabled = false;
            Win_img.SetActive(true);
        }
    }
}
