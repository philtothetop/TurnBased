using UnityEngine;
using System.Collections;

public class tileGenerator : MonoBehaviour {

    public GameObject genericTile;
    public GameObject Cube;

	// Use this for initialization
	void Start () {

        GameObject tileInstance;
        globalScript.Init();
        for (int z = 0; z < globalScript.tileMapSize; z++)
        {
            for (int x = 0; x < globalScript.tileMapSize; x++)
            {
                tileInstance = Instantiate(genericTile, new Vector3(x * 1.02f , .00f, z * 1.02f ), Quaternion.identity) as GameObject;
                tileScript tile = tileInstance.GetComponent<tileScript>();
                tile.setPosition(x, z);
                globalScript.tileMap[x, z] = tile;
            }
        }

        testTeams();
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
        for (int x = 0; x < globalScript.tileMapSize; x++)
        {
            for (int z = 0; z < globalScript.tileMapSize; z++)
            {
                if (globalScript.tileMap[x,z] == tile)
                {
                    x_pos = x;
                    z_pos = z;
                }
            }
        }
    }

    private void testTeams()
    {
        GameObject cubeInstance = Instantiate(Cube) as GameObject;
        characterScript team1character1 = cubeInstance.GetComponent<characterScript>();

        cubeInstance = Instantiate(Cube) as GameObject;
        characterScript team1character2 = cubeInstance.GetComponent<characterScript>();

        teamScript team1 = new teamScript("Blue", Color.blue);
        team1.characterList.Add(team1character1);
        team1.characterList.Add(team1character2);
        team1character1.setCharacter(team1, 0, 0);
        team1character2.setCharacter(team1, 1, 1);


        cubeInstance = Instantiate(Cube) as GameObject;
        characterScript team2character1 = cubeInstance.GetComponent<characterScript>();

        cubeInstance = Instantiate(Cube) as GameObject;
        characterScript team2character2 = cubeInstance.GetComponent<characterScript>();

        teamScript team2 = new teamScript("Red", Color.red);
        team2.characterList.Add(team2character1);
        team2.characterList.Add(team2character2);
        team2character1.setCharacter(team2, globalScript.tileMapSize - 1, globalScript.tileMapSize - 1);
        team2character2.setCharacter(team2, globalScript.tileMapSize - 2, globalScript.tileMapSize - 2);

        globalScript.createTeam(team1);
        globalScript.createTeam(team2);
    }

}
