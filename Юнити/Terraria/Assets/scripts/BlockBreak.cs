using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBreak : MonoBehaviour
{
	public GameObject Block;
    void OnMouseDown(){
    	Destroy(Block);
    }
}
