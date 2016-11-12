using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class globalScript : MonoBehaviour {
    static public int tileMapSize = 10;
    static public tileScript[,] tileMap;
    static public characterScript selectedCharacter;
    static public teamScript currentTeam;
    static public List<teamScript> teamList;

    // Use this for initialization
    void Start () {
	    tileMap = new tileScript[tileMapSize, tileMapSize];
        selectedCharacter = null;
        teamList = new List<teamScript>();
        
    }

    static public void createTeam(teamScript team)
    {
        if (currentTeam == null)
            currentTeam = team;
        teamList.Add(team);
    }
    static public void createTeam(string teamName, Color teamColor, List<characterScript> teamComposition)
    {
        createTeam(new teamScript(teamName, teamColor) {
            characterList = teamComposition
        });
    }


	// Update is called once per frame
	void Update () {
	
	}
}
