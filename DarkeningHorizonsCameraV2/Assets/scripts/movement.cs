using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour 
{

	public float speed = 10;



	// Use this for initialization
	void Start () 
	{
	
	}

	
	// Update is called once per frame
	void Update () 
	{
		float translationV = Input.GetAxis("Vertical") * speed; 
		float translationH = Input.GetAxis("Horizontal") * speed; 

		translationV *= Time.deltaTime;
		translationH *= Time.deltaTime;

		transform.Translate(translationH, 0, translationV);
	}
}
