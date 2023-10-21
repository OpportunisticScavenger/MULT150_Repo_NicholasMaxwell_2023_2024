using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRespawn : MonoBehaviour
{
	//A reference to the game manager
	public GameManager gameManager; 

	// Triggers when the player enters the water
	void OnTriggerEnter(Collider other)
	{
		// Moves the player to the spawn point
		gameManager.PositionPlayer();
	}
}
