using UnityEngine;
using System.Collections;

public class tileScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        GameObject cube = GameObject.FindGameObjectWithTag("SelectedCharacter");
        
        if (cube != null) { 
            Transform characterTransform = cube.GetComponent<Transform>();
            characterTransform.position = new Vector3(transform.position.x, 0.35f, transform.position.z); 
            cube.GetComponent<Renderer>().material.color = Color.white;
            cube.tag = "Character";
            cube.GetComponent<characterScript>().SetCurrentTile(this);
       }
    }


}
