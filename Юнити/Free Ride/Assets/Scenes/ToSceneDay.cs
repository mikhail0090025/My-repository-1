using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ToSceneDay : MonoBehaviour
{
    void OnMouseDown(){
    	SceneManager.LoadScene("SampleScene");
    }
}
