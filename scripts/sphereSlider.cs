using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Required when Using UI elements.

public class sphereSlider : MonoBehaviour {	

	public GameObject sphere;
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
		sphere.transform.localScale = Vector3.one * sl.value;
		print (sphere.transform.localScale);
	}


	
}
