using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour {


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "plyta")
        {
            Destroy(collision.gameObject);
            Instantiate(GM.Atvejis.prtclS, collision.gameObject.transform.position, collision.gameObject.transform.rotation);
            GM.Atvejis.aS.Play();

        }
    }
}
