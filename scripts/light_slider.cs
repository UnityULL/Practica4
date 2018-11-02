using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Required when Using UI elements.

public class light_slider : MonoBehaviour {	

	public Light light;
	private Slider sl;
	// Use this for initialization
	void Start () {		
	        sl = GetComponent<Slider>();
		sl.onValueChanged.AddListener(delegate {ValueChangeCheck(); });		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ValueChangeCheck() {
		light.intensity = sl.value;
	}


	
}
