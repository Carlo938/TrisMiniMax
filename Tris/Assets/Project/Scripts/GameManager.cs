using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

	public enum EntityTurn
	{
		player = 0,
		enemy = 1
	}

	public EntityTurn entityTurn;

    public Grid grid;

    private void Awake()
    {
        instance = this;
    }

    void OnEnable()
    {
        EventManager.changeTurn += CheckTurn;
    }

    // Use this for initialization
    void Start () 
	{
        EventManager.OnChangeTurn((int) EntityTurn.player);
	}

    private void Update()
    {
        if(entityTurn == EntityTurn.enemy)
        {
            grid.CheckEmptyCell().ChangeImage();
        }
    }

    void OnDisable()
    {
        EventManager.changeTurn -= CheckTurn;
    }

    void CheckTurn(int num)
    {
        if(num == 0)
        {
            entityTurn = EntityTurn.player;
        }
        else
        {
            entityTurn = EntityTurn.enemy;
        }
    }

    void CheckVictory()
    {

    }
}
