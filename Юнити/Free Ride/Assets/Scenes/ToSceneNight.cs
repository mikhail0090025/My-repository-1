using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ToSceneNight : MonoBehaviour
{
    void OnMouseDown(){
    	SceneManager.LoadScene("SampleSceneNight");
    }
}
