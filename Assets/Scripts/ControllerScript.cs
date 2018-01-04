using UnityEngine;
using System.Collections;

public class ControllerScript : MonoBehaviour {

	public GameObject prefab1;
	public GameObject prefab2;
	public GameObject prefab3;
	public GameObject button1;
	public GameObject button2;
	public GameObject button3;

	public int interval;
	public int angleX;
	public int angleY;
	public int angleZ;
	private int count;

	// Use this for initialization
	void Start () {
		count = interval-1;
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log (button1.GetComponent<Renderer>().material.color.b);
		if (button1.GetComponent<Renderer> ().material.color.b.Equals (0)) {
			count++;
			if (count > interval) {
				count = 0;
				Instantiate (prefab1, new Vector3 (0, 1, 0), Quaternion.Euler (angleX, angleY, angleZ));
			}
		} else if (button2.GetComponent<Renderer> ().material.color.b.Equals (0)) {
			count++;
			if (count > interval) {
				count = 0;
				Instantiate (prefab2, new Vector3 (0, 1, 0), Quaternion.Euler (angleX, angleY, angleZ));
			}
		} else if (button3.GetComponent<Renderer> ().material.color.b.Equals (0)) {
			count++;
			if (count > interval) {
				count = 0;
				Instantiate (prefab3, new Vector3 (0, 1, 0), Quaternion.Euler (angleX, angleY, angleZ));
			}
		} else if(count!=interval - 1){
			count = interval - 1;
		}
	}

}
