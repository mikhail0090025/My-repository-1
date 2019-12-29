using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuWork : MonoBehaviour
{
	public GameObject menu;
	bool ActiveMenu;
    // Start is called before the first frame update
    void Start()
    {
        ActiveMenu = false;
    }

    void OnMouseDown(){
    	if(ActiveMenu){
    		ActiveMenu = false;
    	}
    	else{
    		ActiveMenu = true;
    	}
    }
    void Update(){
         menu.SetActive(ActiveMenu);
    }
}
