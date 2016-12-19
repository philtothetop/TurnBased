using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class globalScript {
    static public int tileMapSize = 10;
    static public tileScript[,] tileMap;
    static public characterScript selectedCharacter;
    static public teamScript currentTeam;
    static public List<teamScript> teamList;

	static private Board gameBoard;

    // Use this for initialization
    static public void Init () {
		//tileMap = new tileScript[tileMapSize, tileMapSize];

		// Would need to have a board here, with a 1x1 sprited cubes grid
		gameBoard = new Board(tileMapSize, null);
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
}
