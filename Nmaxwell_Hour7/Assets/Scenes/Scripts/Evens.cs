using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evens : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 22; i<=100; i++)
		{
			if (i%2==0)
				{
					print("the following number is an even number: "+i);
				}
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
