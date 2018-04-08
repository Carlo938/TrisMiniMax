using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour 
{
	public delegate void ChangeTurn(int num);
	public static event ChangeTurn changeTurn;

    public delegate void CheckEndGame(int num);
    public static event CheckEndGame checkEndGame;

    public static void OnChangeTurn(int num)
	{
		if(changeTurn != null)  
		{
			changeTurn(num);
		}
	}

    public static void OnCheckEndGame(int num)
    {
        if (checkEndGame != null)
        {
            checkEndGame(num);
        }
    }

}