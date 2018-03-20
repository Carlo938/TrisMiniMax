using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public enum EntityTurn
	{
		player = 0,
		enemy = 1
	}

	public EntityTurn entityTurn;
	// Use this for initialization
	void Start () 
	{
		entityTurn = EntityTurn.player;
		EventManager.OnChangeTurn (0);
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
