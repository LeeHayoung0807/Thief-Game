using UnityEngine;
using System.Collections;

public class Following : MonoBehaviour {

	public Path path;
	public float speed = 20.0f;
	public float mass = 5.0f;
	public bool isLooping = true;
	
	//Actual speed of the vehicle 
	private float deltaDistance;
	
	private int curPathIndex;
	private float pathLength;
	private Vector3 targetPoint;
	
	Vector3 currentDeltaDisplacement;
	
	// Use this for initialization
	void Start () 
	{
		pathLength = path.Length;
		curPathIndex = 0;
		
		//get the current currentDeltaDisplacement of the vehicle
		currentDeltaDisplacement = transform.forward;
	}
	
	// Update is called once per frame
	void Update () 
	{
		//Unify the speed
		deltaDistance = speed * Time.deltaTime;
		
		targetPoint = path.GetPoint(curPathIndex);
		
		//If reach the radius within the path then move to next point in the path
		if(Vector3.Distance(transform.position, targetPoint) < path.Radius)
		{
			//Don't move the vehicle if path is finished 
			if (curPathIndex < pathLength - 1)
				curPathIndex ++;
			else if (isLooping)
				curPathIndex = 0;
			else
				return;
		}

		//Calculate the next currentDeltaDisplacement towards the path
		if(curPathIndex >= pathLength - 1 && !isLooping)
			currentDeltaDisplacement += Steer(targetPoint, true)* Time.deltaTime * Time.deltaTime;
		else
			currentDeltaDisplacement += Steer(targetPoint)* Time.deltaTime * Time.deltaTime;
		
		transform.position += currentDeltaDisplacement; //Move the vehicle according to the currentDeltaDisplacement
		transform.rotation = Quaternion.LookRotation(currentDeltaDisplacement); //Rotate the vehicle towards the desired currentDeltaDisplacement
	}
	
	//Steering algorithm to steer the vector towards the target
	public Vector3 Steer(Vector3 target, bool bFinalPoint = false)
	{
		//Calculate the directional vector from the current position towards the target point
		Vector3 desiredPosDirection = (target - transform.position);
		float dist = desiredPosDirection.magnitude;
		Vector3 desiredDisplacement;
		
		//Normalise the desired currentDeltaDisplacement
		desiredPosDirection.Normalize();
		
		//Calculate the currentDeltaDisplacement according to the speed
		if (bFinalPoint && dist < 10.0f)
			desiredDisplacement = (deltaDistance * (dist / 10.0f))*desiredPosDirection;
		else 
			desiredDisplacement = deltaDistance*desiredPosDirection;
		
		//Calculate the force Vector
		float k = 1.0f / (Time.deltaTime * Time.deltaTime);
		Vector3 steeringForce = k*(desiredDisplacement - currentDeltaDisplacement); 
		Vector3 acceleration = steeringForce / mass;
		
		return acceleration;
	}
}
