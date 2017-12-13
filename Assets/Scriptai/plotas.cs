using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plotas : MonoBehaviour {

    public float plotoGreitis = 1f;

    public AudioSource aS;

    private Vector3 pozicija = new Vector3(0, -9.5f, 0);
	// Use this for initialization
	
	// Update is called once per frame
	void Update () {

        float xPozicija = transform.position.x + (Input.GetAxis("Horizontal") * plotoGreitis);
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D)) aS.Play();
        pozicija = new Vector3(Mathf.Clamp(xPozicija, -8f, 8f), -9.5f, 0f);
        transform.position = pozicija;
		
	}
}
