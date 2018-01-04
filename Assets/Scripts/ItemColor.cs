using UnityEngine;
using System.Collections;

public class ItemColor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Renderer renderer = GetComponent<Renderer> ();
		renderer.material.color = new Color (Random.value,Random.value,Random.value);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
