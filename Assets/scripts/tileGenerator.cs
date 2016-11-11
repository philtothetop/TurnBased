using UnityEngine;
using System.Collections;

public class tileGenerator : MonoBehaviour {

    public Object genericTile;
    public int matriceSize;

    private Object[ , ] tileArray;
	// Use this for initialization
	void Start () {
    Object tile;
        tileArray = new Object[matriceSize, matriceSize];
	for (int z = 0; z < matriceSize; z++)
        {
            for (int x = 0; x < 10; x++)
            {
                
                tile = Instantiate(genericTile, new Vector3(x * 1.02f , .00f, z * 1.02f ), Quaternion.identity);
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

    public void FindIndexOfTile(Object tile, out int x_pos, out int z_pos)
    {
        x_pos = -1;
        z_pos = -1;
        for (int x = 0; x < matriceSize; x++)
        {
            for (int z = 0; z < matriceSize; z++)
            {
                if (tileArray[x,z] == tile)
                {
                    x_pos = x;
                    z_pos = z;
                }
            }
        }
    }

}
