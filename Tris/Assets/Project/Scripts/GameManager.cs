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
        EventManager.checkEndGame += CheckEndGame;
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
        EventManager.checkEndGame -= CheckEndGame;
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

    private void CheckEndGame(int num)
    {
        CheckHorizontal(num);
        CheckVertical(num);
        CheckDiagonal(num);
        CheckInverseDiagonal(num);
    }

    private void CheckHorizontal(int num)
    {
        for (int i = 0; i < grid.raws.Length; i++)
        {
            int count = 0;

            for (int j = 0; j < grid.raws[i].cells.Length; j++)
            {
                if (grid.raws[i].cells[j].entity == num)
                {
                    count++;
                    if (count == 3)
                    {
                        Debug.Log("FineGiuoco!");
                    }
                }
                else
                {
                    continue;
                }
            }
        }
    }

    private void CheckVertical(int num)
    {

        for (int k = 0; k < 3; k++)
        {
            int count = 0;
            for (int i = 0; i < grid.raws.Length; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    if (grid.raws[i].cells[j + k].entity == num)
                    {
                        count++;
                        if (count == 3)
                        {
                            Debug.Log("FineGiuoco!");
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }

        }
    }

    private void CheckDiagonal(int num)
    {
        int count = 0;

        for (int i = 0; i < grid.raws.Length; i++)
        {
            if (grid.raws[i].cells[i].entity == num)
            {
                count++;
                if (count == 3)
                {
                    Debug.Log("FineGiuoco!");
                }
            }
            else
            {
                continue;
            }
        }
    }

    private void CheckInverseDiagonal(int num)
    {
        int count = 0;

        for (int i = 0, j = grid.raws.Length - 1; i < grid.raws.Length && j >= 0; i++, j--)
        {
            if (grid.raws[i].cells[j].entity == num)
            {
                count++;
                if (count == 3)
                {
                    Debug.Log("FineGiuoco!");
                }
            }
            else
            {
                continue;
            }
        }
    }
}
