using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{
    public static bool Act;
    // Start is called before the first frame update
    void Start()
    {
        Act = true;
    }

    // Update is called once per frame
    void Update()
    {
    if(Act){
        UnityEngine.Cursor.visible = false;
        Screen.lockCursor = true;
    }
    if(!Act){
        UnityEngine.Cursor.visible = true;
        Screen.lockCursor = false;
    }
    }
}
