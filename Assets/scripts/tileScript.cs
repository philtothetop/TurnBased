using UnityEngine;
using System.Collections;

public class tileScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void onMouseDown()
    {
        Object movedCharacter = GameObject.FindGameObjectWithTag("Character");
        Debug.Log(movedCharacter);
        Vector3 pos = transform.position;
        Debug.Log(transform.position);
        ((Transform)movedCharacter).position = pos;
    }
}
