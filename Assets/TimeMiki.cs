using UnityEngine;
using System.Collections;

public class TimeMiki : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (PlayerControl.trigger)
        {
            Destroy(gameObject);
            PlayerControl.trigger = false;
        }
	}
}
