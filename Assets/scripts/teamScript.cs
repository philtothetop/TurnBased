using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class teamScript {
    public List<characterScript> characterList;
    public string teamName;
    public Color teamColor;
	// Use this for initialization
    public teamScript(): this("team", Color.white){}
    public teamScript(string teamName, Color teamColor)
    {
        this.teamName = teamName;
        this.teamColor = teamColor;
        characterList = new List<characterScript>();
    }


	// Update is called once per frame
	void Update () {
	
	}
}
