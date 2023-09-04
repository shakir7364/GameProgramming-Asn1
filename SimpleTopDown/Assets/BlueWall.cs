using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueWall : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnTriggerStay2D(Collider2D collider)
    {
        collider.gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        collider.gameObject.GetComponent<SpriteRenderer>().color = Color.white;
    }
}
