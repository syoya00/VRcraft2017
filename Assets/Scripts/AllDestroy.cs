using UnityEngine;
using System.Collections;

public class AllDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		SteamVR_TrackedObject trackedObject = GetComponent<SteamVR_TrackedObject>();
		var device = SteamVR_Controller.Input((int) trackedObject.index);

		if (device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger)) {
			GameObject[] prefabs = GameObject.FindGameObjectsWithTag ("Item");
			foreach (var i in prefabs) {
				Destroy (i.gameObject);
			}
		}
	}
}
