using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reload_Scene : MonoBehaviour
{
    public void OnClick(){
        SceneManager.LoadScene("Game");
    }
}
