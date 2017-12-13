using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamuolys : MonoBehaviour {

    public GameObject prtclS;

    public AudioSource aS;

    public float kamuolioPagreitis = 600f;

    private Rigidbody rb;
    private bool KVeikia;
	// Use this for initialization
	void Awake () {

        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
        if (Input.GetButtonDown("Fire1") && KVeikia == false)
        {
            transform.parent = null;
            KVeikia = true;
            rb.isKinematic = false;
            rb.AddForce(new Vector3(kamuolioPagreitis, kamuolioPagreitis, 0));
        }
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "plyta")
        {
            Destroy(collision.gameObject);
            Instantiate(prtclS, collision.gameObject.transform.position, collision.gameObject.transform.rotation);
            aS.Play();

        }
    }
}
