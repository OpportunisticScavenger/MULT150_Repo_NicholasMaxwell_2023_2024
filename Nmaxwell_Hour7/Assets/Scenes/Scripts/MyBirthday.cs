using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
	for (int iterateMonth=1; iterateMonth<=12; iterateMonth++)
		{
			if (iterateMonth==1||iterateMonth==3||iterateMonth==5||iterateMonth==7||iterateMonth==8||iterateMonth==10||iterateMonth==12)
				{
					for (int iterateDay=1; iterateDay<=31; iterateDay++)
						{
							if (iterateMonth==5&&iterateDay==9)
								{
									print ("I was going to do something snarky here about how I don't want to reveal my birthday, but I realized it would honestly just be easier to put my birthday here. May ninth, my birthday.");
								}
							else
								{
									print ("month "+iterateMonth+" day "+iterateDay);
								}
						}
				}
			else if (iterateMonth!=2)
				{
					for (int iterateDay=1; iterateDay<=30; iterateDay++)
						{
							print ("month "+iterateMonth+" day "+iterateDay);
						}
				}
			else
				{
					for (int iterateDay=1; iterateDay<=28; iterateDay++)
						{
							print ("month "+iterateMonth+" day "+iterateDay);
						}
				}
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
