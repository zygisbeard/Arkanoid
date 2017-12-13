using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fieldofview : MonoBehaviour {

    public Camera mainCamera;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //if (mainCamera.fieldOfView > 65)
            mainCamera.fieldOfView = Mathf.Lerp(mainCamera.fieldOfView, 65, 0.1f);
            //mainCamera.fieldOfView = mainCamera.fieldOfView - 5;
	}
}
