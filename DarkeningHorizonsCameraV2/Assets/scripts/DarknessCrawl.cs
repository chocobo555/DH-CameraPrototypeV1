using UnityEngine;
using System.Collections;

public class DarknessCrawl : MonoBehaviour 
{
	GameObject physicalCharacter;
	bool isChasing = false;
	public float darknessSpeed;


	// Use this for initialization
	void Start () 
	{
		physicalCharacter = GameObject.Find("PhysicalCharacter");
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (isChasing == true) 
		{
			float step = darknessSpeed * Time.deltaTime;
			gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, physicalCharacter.transform.position, step);
		}
	}

	void OnTriggerEnter()
	{
		print("bloop");
		isChasing = true;
	}

	void Chase()
	{

	}


}
