using UnityEngine;
using System.Collections;

public class gameObject : MonoBehaviour {

    public Transform genericTile;
    private Object[ , ] tileArray = new Object[10,10];
	// Use this for initialization
	void Start () {
    Object tile;
	for (int z = 0; z < 10; z++)
        {
            for (int x = 0; x < 10; x++)
            {
                
                tile = Instantiate(genericTile, new Vector3(x * 1.02f , .01f, z * 1.02f ), Quaternion.identity);
                tileArray[x, z] = tile;
            }
        }

    }
	
	// Update is called once per frame
	void Update () {
	    // If character has been selected
            // Determine with raycast which tile has been selected
            // set character position to tile position 
	}

}
