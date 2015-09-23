using UnityEngine;
using System.Collections;

public class SceneChange : MonoBehaviour {

    private GameObject scene1;
    private GameObject scene2;
    private bool trigger;
	// Use this for initialization
	void Start () {
        scene1 = GameObject.FindWithTag("Scene1");
        scene2 = GameObject.FindWithTag("Scene2");
        scene2.SetActive(false);
        trigger = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.L))
        {
            trigger = !trigger;
            scene1.SetActive(trigger);
            scene2.SetActive(!trigger);
        }
	}
}
