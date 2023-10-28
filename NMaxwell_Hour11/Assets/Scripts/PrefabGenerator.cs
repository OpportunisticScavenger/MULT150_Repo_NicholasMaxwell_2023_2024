using UnityEngine;
public class PrefabGenerator : MonoBehaviour
{
public GameObject prefab;
void Start()
{
	for (int j=0;j<10;j++)
	{
		Vector3 spawnOffset = new Vector3(-5+j, 0, -5);
		Instantiate(prefab, spawnOffset, transform.rotation);
	}
}
void Update()
{
// Whenever we hit the B key we will generate a prefab at the
// position of the original prefab
// Whenever we hit the space key, we will generate a prefab at the
// position of the spawn object that this script is attached to
if (Input.GetKeyDown(KeyCode.B))
{
Instantiate(prefab);
}
if (Input.GetKeyDown(KeyCode.Space))
{
Instantiate(prefab, transform.position, transform.rotation);
}
}
}