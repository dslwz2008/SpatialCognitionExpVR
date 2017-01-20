using UnityEngine;
using System.Collections;

public class TestControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float x = Input.GetAxisRaw("Oculus_GearVR_LThumbstickX");
        float y = Input.GetAxisRaw("Oculus_GearVR_LThumbstickY");
        Debug.Log(x.ToString() + "\t"+ y.ToString());
        //transform.Translate(transform.right*x);
        //transform.Translate(transform.forward * y);
	}
}
