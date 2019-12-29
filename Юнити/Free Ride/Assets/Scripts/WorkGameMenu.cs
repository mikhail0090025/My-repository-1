using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkGameMenu : MonoBehaviour
{
	public GameObject menu;
	public bool menu_active;
	void Start(){
		menu_active = false;
	}
    void Update()
    {
    	menu.SetActive(menu_active);
        if(Input.GetKeyDown(KeyCode.E)){
            menu_active = !menu_active;
        }
    }
}
