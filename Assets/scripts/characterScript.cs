using UnityEngine;
using System.Collections;

public class characterScript : MonoBehaviour {

    private Object currentTile;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

    }

    void OnMouseDown()
    {
        tag = "SelectedCharacter";
        GetComponent<Renderer>().material.color = Color.blue;
        int x_pos = -1;
        int z_pos = -1; 
        
    }

    public void SetCurrentTile(Object tile)
    {
        currentTile = tile;
    }
}
