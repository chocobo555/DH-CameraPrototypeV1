using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour 
{

	public GameObject physicalCharacter;
	Vector3 myPos;



	// Use this for initialization
	void Start () 
	{
		
	}


	// Update is called once per frame
	void Update () 
	{

		gameObject.transform.position = physicalCharacter.transform.position;

	}
}
