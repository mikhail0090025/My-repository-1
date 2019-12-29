using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
	public Transform nm;
	float raydi;
	public GameObject Where;
	public Transform mn;
	public Transform r;
	public Transform pistol;
	int x = Random.Range(-20, 20);
	int y = Random.Range(-20, 20);
	public AudioSource sound;
    void Update()
    {
    	Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    	RaycastHit hit;
    	if(Input.GetMouseButtonDown(0)){
        //MousesSpawn.d = true;
        sound.Play();
        if(Physics.Raycast(ray, out hit))Instantiate(Where, hit.point, Quaternion.identity);
        if(hit.collider.gameObject.name == "fff" || hit.collider.gameObject.name == "MouseBodyStandart" ){
        	Destroy(hit.collider.gameObject);
        }
    }
    }
}
