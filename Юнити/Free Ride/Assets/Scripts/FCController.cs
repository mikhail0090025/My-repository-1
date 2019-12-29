using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace characters{
public class FCController : MonoBehaviour {

    public Transform up;
    public Transform down;
    public int MoveSpeed = 7;
    public int RotateSpeed = 5;
    public Transform jump;
    public int JumpHeight = 5;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.W)){
            transform.position = Vector3.MoveTowards(transform.position, up.position, Time.deltaTime * MoveSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Quaternion rotationY = Quaternion.AngleAxis(RotateSpeed - RotateSpeed * 2, Vector3.up);
            transform.rotation *= rotationY;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = Vector3.MoveTowards(transform.position, down.position, Time.deltaTime * MoveSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Quaternion rotationY = Quaternion.AngleAxis(RotateSpeed, Vector3.up);
            transform.rotation *= rotationY;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position = Vector3.MoveTowards(transform.position, jump.position, Time.deltaTime * JumpHeight);
        }
	}
}
}