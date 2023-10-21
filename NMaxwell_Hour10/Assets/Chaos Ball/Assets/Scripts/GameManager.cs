using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class GameManager : MonoBehaviour
{

	// So that we can access the player's controller from this script
	private FirstPersonController fpsController;
	public GameObject player;
	public Transform spawnPoint;

	public GameObject blueBall;
	public GameObject redBall;
	public GameObject greenBall;
	public GameObject orangeBall;

	public Transform blueSpawnPoint;
	public Transform redSpawnPoint;
	public Transform greenSpawnPoint;
	public Transform orangeSpawnPoint;

	public Transform cornerPocket;

	// Use this for initialization
	void Start ()
	{
		//Tell Unity to allow character controllers to have their position set directly. This will enable our respawn to work
		Physics.autoSyncTransforms = true;

		// Finds the First Person Controller script on the Player
		fpsController = player.GetComponent<FirstPersonController> ();
	
		// Disables controls at the start.
		fpsController.enabled = false;
	}


	public GoalScript blue, green, red, orange;
	private bool isGameOver = true;	
	
	// Flags that control the state of the game
	private float elapsedTime = 0;
	private bool isRunning = false;
	private bool isFinished = false;

	//This resets to game back to the way it started
	private void StartGame()
	{
		elapsedTime = 0;
		isRunning = true;
		isFinished = false;
		blue.isSolved=false;
		red.isSolved=false;
		green.isSolved=false;
		orange.isSolved=false;
		blue.GetComponent<Light>().enabled = true;
		red.GetComponent<Light>().enabled = true;
		green.GetComponent<Light>().enabled = true;
		orange.GetComponent<Light>().enabled = true;




		// Move the player to the spawn point, and allow it to move.
		PositionPlayer();
		fpsController.enabled = true;
		PositionBlue();
		PositionRed();
		PositionGreen();
		PositionOrange();

	}

	// Runs when the player enters the finish zone
	public void FinishedGame()
	{
		isRunning = false;
		isFinished = true;
	}
	//Runs when the player needs to be positioned back at the spawn point
	public void PositionPlayer()
	{
		player.transform.position = spawnPoint.position;
		player.transform.rotation = spawnPoint.rotation;
	}
	public void PositionBlue()
	{
		blueBall.transform.position = blueSpawnPoint.position;
		blueBall.transform.rotation = blueSpawnPoint.rotation;
	}
	public void PositionRed()
	{
		redBall.transform.position = redSpawnPoint.position;
		redBall.transform.rotation = redSpawnPoint.rotation;
	}
	public void PositionGreen()
	{
		greenBall.transform.position = greenSpawnPoint.position;
		greenBall.transform.rotation = greenSpawnPoint.rotation;
	}
	public void PositionOrange()
	{
		orangeBall.transform.position = orangeSpawnPoint.position;
		orangeBall.transform.rotation = orangeSpawnPoint.rotation;
	}
	

	public void PocketBlue()
	{
		blueBall.transform.position = cornerPocket.position;
		blueBall.transform.rotation = cornerPocket.rotation;
	}
	public void PocketRed()
	{
		redBall.transform.position = cornerPocket.position;
		redBall.transform.rotation = cornerPocket.rotation;
	}
	public void PocketGreen()
	{
		greenBall.transform.position = cornerPocket.position;
		greenBall.transform.rotation = cornerPocket.rotation;
	}
	public void PocketOrange()
	{
		orangeBall.transform.position = cornerPocket.position;
		orangeBall.transform.rotation = cornerPocket.rotation;
	}

	
	

	void Update ()
	{
		// If all four goals are solved then the game is over
		isGameOver = blue.isSolved && green.isSolved && red.isSolved && orange.isSolved;	
		
		// Add time to the clock if the game is running
		if (isRunning)
		{
			elapsedTime = elapsedTime + Time.deltaTime;
		}	
	}

	void OnGUI()
	{
		if(!isRunning)
		{
			string message;

			if(isFinished)
			{
				message = "Click or Press Enter twice to Play Again";
			}
			else
			{
				message = "Click or Press Enter to Play";
			}

			//Define a new rectangle for the UI on the screen
			Rect startButton = new Rect(Screen.width/2 - 120, Screen.height/2, 240, 30);

			if (GUI.Button(startButton, message) || Input.GetKeyDown(KeyCode.Return))
			{
				//start the game if the user clicks to play
				StartGame ();
			}
		}
		
		// If the player finished the game, show the final time
		if(isFinished)
		{
			GUI.Box(new Rect(Screen.width / 2 - 65, 185, 130, 40), "Your Time Was");
			GUI.Label(new Rect(Screen.width / 2 - 10, 200, 20, 30), ((int)elapsedTime).ToString());
		}
		else if(isRunning)
		{ 
			// If the game is running, show the current time
			GUI.Box(new Rect(Screen.width / 2 - 65, Screen.height - 115, 130, 40), "Your Time Is");
			GUI.Label(new Rect(Screen.width / 2 - 10, Screen.height - 100, 20, 30), ((int)elapsedTime).ToString());
		}
		if(isGameOver) {
			
			isFinished=true;
			isRunning=false;
			
			Rect rect = new Rect (Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 75);
			GUI.Box (rect, "Game Over");

			Rect rect2 = new Rect (Screen.width / 2 - 30, Screen.height / 2 - 25, 60, 50);
			GUI.Label (rect2, "Good Job!");
		}
	}
}