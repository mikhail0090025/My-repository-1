using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace iim{
public class IImouses : MonoBehaviour {
    public Transform up;
    public int MoveSpeed = 3;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.MoveTowards(transform.position, up.position, Time.deltaTime * MoveSpeed);
        Quaternion rotationY = Quaternion.AngleAxis(Random.Range(-6, 6), Vector3.up);
        transform.rotation *= rotationY;
	}
    void OnTriggerEnter(Collider mousenotswim)
    {
        if (mousenotswim.gameObject.name == "ocean")
        {
            transform.position = new Vector3(471, 102, 345);
        }
    }
}
}