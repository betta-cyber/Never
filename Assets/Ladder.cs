using UnityEngine;
using System.Collections;

public class Ladder : MonoBehaviour {

    public GameObject ladderPlatform;

    public void OnTriggerEnter2D(Collider2D other)
	{
		// we check that the player is actually colliding with the ladder
		//var player = other.GetComponent<Player>();
		//if (player==null)
			//return;
		
		//var controller = other.GetComponent<CorgiController2D>();
		//if (controller==null)
			//return;		
	}

    public void OnTriggerStay2D(Collider2D other) 
    {

    }

    public void OnTriggerExit2D(Collider2D other)
    {

    }
}
