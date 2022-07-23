using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchingPlayer : MonoBehaviour
{
    [SerializeField]private ParticleController ParticleControllerScript;
    [SerializeField]private int CountOfParticles, Price;
    [SerializeField]private ScoreRegistrator ScoreRegistratorScript;

    private void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("Player")){
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            ParticleControllerScript.Begin(CountOfParticles);
            ScoreRegistratorScript.SetNewScore(Price);
            Destroy(gameObject, 2.0f);
        }
    }
}
