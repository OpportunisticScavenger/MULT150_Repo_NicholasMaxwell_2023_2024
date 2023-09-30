using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    	public float horizontalSpeed = 2.0F;
	public float verticalSpeed = 2.0F;
	
	public float yaw = 0.0F;
	public float pitch = 0.0F;
	
	


// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      	yaw += horizontalSpeed*Input.GetAxis("Mouse X");
	pitch -= verticalSpeed*Input.GetAxis("Mouse Y");
	transform.eulerAngles = new Vector3(pitch, yaw, 0.0F);

	float mxVal = Input.GetAxis("Mouse X");
	float myVal = Input.GetAxis("Mouse Y");
	if (mxVal != 0)
		{
			print("Mouse X movement selected: "+mxVal);
		}
	if (myVal !=0)
		{
			print("Mouse Y movement selected: "+myVal);
		}
    }
}
