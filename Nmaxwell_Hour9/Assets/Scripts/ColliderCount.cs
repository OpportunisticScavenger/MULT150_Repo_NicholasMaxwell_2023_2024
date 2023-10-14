using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderCount : MonoBehaviour
{
     float counting = 0;

void OnTriggerEnter (Collider other)
	{
		counting++;
print(other.gameObject.name + " has entered the counting cube " + counting + " times.");
	}



// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
