using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace n{
public class Cam : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            Quaternion rotationY = Quaternion.AngleAxis(5, Vector3.left);
            transform.rotation *= rotationY;
        }
        if (Input.GetKey(KeyCode.F))
        {
            Quaternion rotationY = Quaternion.AngleAxis(5, Vector3.right);
            transform.rotation *= rotationY;
        }
    }
}
}