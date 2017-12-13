using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plytos : MonoBehaviour {

   // GM gm;

    public GameObject plytaPrtckl;

	void OnCollisionEnter (Collision other)
    {
      
        Instantiate(plytaPrtckl, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
