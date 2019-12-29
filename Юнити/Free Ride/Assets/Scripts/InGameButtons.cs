using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class InGameButtons : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F)){
        	//SceneManager.LoadScene("Menu");
        	//Cursor.Act = false;
        }
    }
}
