using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    public Raw[] raws;
    public Sprite x;
    public Sprite o;

    private void Awake()
    {
        AssignSprite();
    }

    public void AssignSprite()
    {
        for(int i = 0; i < raws.Length; i++)
        {
            for(int j = 0; j < raws[i].cells.Length; j++)
            {
                raws[i].cells[j].playerSprite = x;
                raws[i].cells[j].aISprite = o;
            }
        }
    }

    public Cell CheckEmptyCell()
    {
        for (int i = 0; i < raws.Length; i++)
        {
            for (int j = 0; j < raws[i].cells.Length; j++)
            {
                if(raws[i].cells[j].isEmpty)
                {
                    return raws[i].cells[j];
                }
            }
        }

        return null;
    }


}
