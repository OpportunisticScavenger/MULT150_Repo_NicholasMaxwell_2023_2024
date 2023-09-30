using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightUp : MonoBehaviour
{
    private Light lightComponent;
	// Start is called before the first frame update
    void Start()
    {
        lightComponent = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.L))
		{

			lightComponent.enabled = false;
		}
	else
		{

			lightComponent.enabled = true;
		}
    }
}
