using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using Gvr;

public class monoMode : MonoBehaviour {

	//public bool setStereoMode;

		//public void setStereoModeEnabled () {

		//XRSettings.enabled = false;
		//Camera.main.ResetAspect ();
		//Camera.main.Render = InputTracking.GetLocalRotation(XRNode.CenterEye);
		//setStereoMode = true;

	//}
	// Use this for initialization
	void Start () {

		XRSettings.enabled = true;
		StartCoroutine(LoadDevice ("cardboard", false));
		Camera.main.ResetAspect ();
	}
	
	// Update is called once per frame
	void Update () {


	}

	IEnumerator LoadDevice(string newDevice, bool enable)
	{
		XRSettings.LoadDeviceByName(newDevice);
		yield return null;
		XRSettings.enabled = enable;
	}

	void EnableVR()
	{
		StartCoroutine(LoadDevice("cardboard", true));
	}

	void DisableVR()
	{
		StartCoroutine(LoadDevice("", false));
	}

}