using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class destroyer : MonoBehaviour {

    public int lives = 3;
    public Text GyvTextas;
    public GameObject DefTextas;



    // Use this for initialization
    void Start () {
        GyvTextas.text = "LIVES LEFT " +  lives.ToString();
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ball")
        {
            if (lives > 0) lives--;
            if (lives <= 0) {
                Destroy(collision.gameObject);
            DefTextas.SetActive(true); }
            GyvTextas.text = "LIVES LEFT " + lives.ToString();

        }
    }

}
