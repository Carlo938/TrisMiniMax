using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour 
{
	public delegate void ChangeTurn(int num);
	public static event ChangeTurn changeTurn; 

	public static void OnChangeTurn(int num)
	{
		if(changeTurn != null)  
		{
			changeTurn(num);
		}
	}

}