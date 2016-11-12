using UnityEngine;
using System.Collections;

public class characterScript : MonoBehaviour {
    public int x, z;
    public teamScript team;
    private Object currentTile;
    public bool selected;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

    }

    public void setCharacter(teamScript team, int x, int z)
    {
        this.team = team;
        DeselectCharacter();
        GetComponent<Renderer>().material.color = team.teamColor;
        Move(x, z);
    }

    void OnMouseDown()
    {
        if (team == globalScript.currentTeam)
        {

            if (selected)
                DeselectCharacter();
            else
            {
                if (globalScript.selectedCharacter != null)
                    globalScript.selectedCharacter.DeselectCharacter();
                SelectCharacter();
            }
        }
        //int x_pos = -1;
        //int z_pos = -1; 
        
    }

    public void SelectCharacter()
    {
        globalScript.selectedCharacter = this;
        selected = true;
        GetComponent<Renderer>().material.color = Color.yellow;
    }

    public void DeselectCharacter()
    {
        globalScript.selectedCharacter = null;
        selected = false;
        GetComponent<Renderer>().material.color = team.teamColor;
    }

    public void Move(int x, int z)
    {
        if (this.x != x || this.z != z)
        {
            transform.position = new Vector3(1.02f * x, 0.35f, 1.02f * z);
            this.x = x;
            this.z = z;
        }
    }

    public void SetCurrentTile(Object tile)
    {
        currentTile = tile;
    }
}
