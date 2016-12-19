using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {
	private float xPos;
	private float yPos;
	private bool movable; 
	public GameObject tileObject;

	public Tile()
	{
		xPos = 0;
		yPos = 0;
		movable = false;
	}

	public Tile(float xPos, float yPos) 
	{
		this.xPos = xPos;
		this.yPos = yPos;
		movable = false;
	}

	public float getXPosition() { return this.xPos; }
	public float getYPosition() { return this.yPos; }

	public void setMovable(bool movable) { this.movable = movable; }

}
