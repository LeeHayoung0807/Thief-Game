using UnityEngine;
using System.Collections;

public class Touch : Sense
{

    void OnTriggerEnter(Collider other)
    {
        Aspect aspect = other.GetComponent<Aspect>();
        if (aspect != null)
        {
            //Check the aspect
            if (aspect.aspectName == aspectName)
            {
				print(aspectName + " Touch Detected");
				PlayerStatus.founded = true;
				//turn to the player code
            }
        }
    }

}
