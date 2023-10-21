using UnityEngine;

public class GoalScript : MonoBehaviour
{
	public bool isSolved = false;

	public GameManager gameManager; 

	void OnTriggerEnter (Collider collider)
	{
		GameObject collidedWith = collider.gameObject;
		
		if (collidedWith.tag == gameObject.tag)
		{
			isSolved = true;
			GetComponent<Light>().enabled = false;

			if (gameObject.tag == "Blue"){
				gameManager.PocketBlue();
			}
			else if (gameObject.tag == "Red"){
				gameManager.PocketRed();
			}
			else if (gameObject.tag == "Green"){
				gameManager.PocketGreen();
			}
			else if (gameObject.tag == "Orange"){
				gameManager.PocketOrange();
			}
		}
	}
}