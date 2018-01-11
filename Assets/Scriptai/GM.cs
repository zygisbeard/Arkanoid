using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GM : MonoBehaviour {

    private static GM atvejis;
    public float speed = 1f;
    public int lives = 3;
    public Text GyvTextas;
    public GameObject DefTextas;
    public GameObject prtclS;
    public AudioSource aS;
    public float kamuolioPagreitis = 600f;
    public GameObject plytaPrtckl;
    public Camera mainCamera;
    public AudioSource aSS;

    public static GM Atvejis
    {
        get { return atvejis; }
    }

    private void Awake()
    {
        if(atvejis == null)
        {
            atvejis = this;
        }
    }

    void Start () {
		
	}
	

	void Update () {
		
	}
}
