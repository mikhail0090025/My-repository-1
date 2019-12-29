using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Optimization : MonoBehaviour
{
    public int Distance;
    public Transform MainPlayer;
    public GameObject b;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Vector3.Distance(transform.position, MainPlayer.position) >= Distance)
        {
            b.SetActive(false);
        }
        else
        {
            b.SetActive(true);
        }
	}
}
