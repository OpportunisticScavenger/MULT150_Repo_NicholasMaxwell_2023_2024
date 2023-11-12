using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControl : MonoBehaviour
{
    // Start is called before the first frame update
Animator anim;
    void Start()
    {
        anim= GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("a")){
		anim.SetTrigger ("ColorChange");	
	}
	if (Input.GetKeyDown("w")){
		anim.SetTrigger ("Hover");
	}
	if (Input.GetKeyDown("s")){
		anim.SetTrigger ("Rotate");
	}
	if (Input.GetKeyDown("d")){
		anim.SetTrigger ("Scale");
	}
	
    }
}
