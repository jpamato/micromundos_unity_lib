﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagController : MonoBehaviour {

	public int id;

	// Use this for initialization
	void Start () {
	}

	public void OnBlockDetected(){
		/*detected = true;
		Instantiate (gameObject);*/
	}

	public void OnBlockExit(){
		Destroy (gameObject, 1);
	}

	public void SetRotation(){
			transform.eulerAngles = MicromundosManager.Instance.GetBlockRotation(id);
	}

	public void SetPosition(Camera cam){
			transform.localPosition = MicromundosManager.Instance.GetBlockPosition (id, cam);
	}

	public void OnUpdate () {
		
	}
}
