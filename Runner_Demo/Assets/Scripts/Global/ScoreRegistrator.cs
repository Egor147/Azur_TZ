using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreRegistrator : MonoBehaviour
{
    [SerializeField]private Text Score_txt;
    private float Score;

    private void Start(){
        Score = 0;
    }

    public void SetNewScore(int value){
        Score += value;
        Score_txt.text = Score.ToString();
    }
}
