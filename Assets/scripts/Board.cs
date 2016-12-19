using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board {

	private int size;
	private Tile[,] board;
	public GameObject boardObject;

	public Board(int boardSize, GameObject boardObject)
	{
		this.boardObject = boardObject;
		board = new Tile[boardSize, boardSize];
		for (int i = 0; i < boardSize; ++i)
		{
			for (int j = 0; j < boardSize; ++j)
			{
				board[i, j] = new Tile(i, j);
			}
		}
	}

	public Tile getTileAtPos(int xPos, int yPos)
	{
		return board[xPos, yPos];
	}

	// To let a player move, here are the steps:
	// click on the character -> must become selected
	// determine movable tiles -> change color & set as Movable tile
	// click on the interested tile ->
	//	- move character to tile position
	//	- set all tiles to unmovable 
	//  NOTE TO SELF: There must be a way to calculate that the selected tile is in range
	// 	- deselect character 

	// Let's start at 3-case move, needs to get tiles where I can move
	// - - - - - - - - - -
	//| | | | | |M| | | | |
	// - - - - - - - - - -
	//| | | | |M|M|M| | | |
	// - - - - - - - - - -
	//| | | |M|M|M|M|M| | |
	// - - - - - - - - - -
	//| | |M|M|M|P|M|M|M| |
	// - - - - - - - - - -
	//| | | |M|M|M|M|M| | |
	// - - - - - - - - - -
	//| | | | |M|M|M| | | |
	// - - - - - - - - - -
	//| | | | | |M| | | | |
}
