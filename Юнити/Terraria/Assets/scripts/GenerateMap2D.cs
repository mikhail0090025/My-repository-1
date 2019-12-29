using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GenerateMap2D : MonoBehaviour
{
	public GameObject GrassBlock;
	public GameObject Land;
	public GameObject player;
	public GameObject st;
	public Text txt;
	public GameObject tx;
	public Transform GrassBlok;
	int rnd = 0;
	float x = -10000.1f;
	float y = 2.5f;
	void Start(){
         player.SetActive(false);
         st.SetActive(true);
	}
    void OnMouseDown()
    {
    	player.SetActive(true);
        st.SetActive(false);
    	GrassBlok.position = new Vector3(-9.863068f, 2.5f, 0);
    	txt.text = "Создание блоков травы...";
        for(int i = 0; i < 20000; i++){
        	//rnd = rnd + Random.Range(-1, 1);
            Instantiate(GrassBlock, new Vector3(x, y, 0), Quaternion.identity);
            x++;
        }
        tx.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
