using UnityEngine;
using System.Collections;

public class DarknessCrawl : MonoBehaviour 
{
	GameObject physicalCharacter;
	bool inRange = false;
	bool inView = false;
	public float darknessSpeed;


	// Use this for initialization
	void Start () 
	{
		physicalCharacter = GameObject.Find("PhysicalCharacter");
	}

	
	// Update is called once per frame
	void Update () 
	{
		//if (inRange == true)
			//print ("inRange true");

		//if (inView == true)
			//print ("inView true");

		/*
		if (inRange == true && inView == false)
		{
			print ("yeah!!");
			float step = darknessSpeed * Time.deltaTime;
			gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, physicalCharacter.transform.position, step);
		}
		*/
	}


	void OnWillRenderObject()
	{
		if(Camera.current.name == "LeftEyeAnchor" || Camera.current.name == "RightEyeAnchor")
		{
			print ("yeah");
			inView = true;
		}
	}
	/*
	void OnBecameInvisible()
	{
		inView = false;
	}
	*/


	void OnTriggerEnter()
	{
		inRange = true;
	}
	void OnTriggerExit()
	{
		inRange = false;
	}

}
