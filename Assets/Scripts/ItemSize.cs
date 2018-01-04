using UnityEngine;
using System.Collections;

public class ItemSize : MonoBehaviour {

	public GameObject materX;
	public GameObject materY;
	public GameObject materZ;
	public float defaultX = 0.293f;
	public float range = 0.3f;

	// Use this for initialization
	void Start () {

		materX = GameObject.Find ("materX");
		materY = GameObject.Find ("materY");
		materZ = GameObject.Find ("materZ");

		//xが0.288? から -0.193程度まで変化することを確認

		Transform transform = GetComponent<Transform> ();

		float x = transform.localScale.x * (1.0f + (defaultX - materX.transform.localPosition.x)*6.0f);
		float y = transform.localScale.y * (1.0f + (defaultX - materY.transform.localPosition.x)*6.0f);
		float z = transform.localScale.z * (1.0f + (defaultX - materZ.transform.localPosition.x)*6.0f);

		transform.localScale = new Vector3 (x,y,z);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
