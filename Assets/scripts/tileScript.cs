using UnityEngine;
using System.Collections;

public class tileScript : MonoBehaviour {
    public int x, z;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public bool setPosition(int x, int z)
    {
        this.x = x;
        this.z = z;
        return true;
    }

    void OnMouseDown()
    {
        characterScript cube = globalScript.selectedCharacter;
        
        if (cube != null) {
            Transform characterTransform = cube.transform;
            cube.Move(x,z);
            cube.DeselectCharacter();
            cube.SetCurrentTile(this);
       }
    }


}
