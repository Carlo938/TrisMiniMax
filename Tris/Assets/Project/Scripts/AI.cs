using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour 
{

	void OnEnable()
	{
		EventManager.changeTurn += Turn;
	}

	void OnDisable()
	{
		EventManager.changeTurn -= Turn;
	}


	public void Turn(int num)
	{
		
	}
}
