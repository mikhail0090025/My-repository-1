using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadSecondScene : MonoBehaviour
{
    void Update()
    {
    	if(Input.GetKey(KeyCode.Escape) || Input.GetKey(KeyCode.Space)){
    	SceneManager.LoadScene("Menu");
    }
    }
}
