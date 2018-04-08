using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cell : MonoBehaviour
{
    private Image imag;
    public Sprite playerSprite;
    public Sprite aISprite;
    public bool isEmpty = true;
    [HideInInspector]
    public int entity = -1;

	// Use this for initialization
	void Awake ()
    {
        imag = GetComponentInChildren<Image>();
	}
	
	public void ChangeImage()
    {
        if(GameManager.instance.entityTurn != GameManager.EntityTurn.enemy)
        {
            imag.sprite = playerSprite;
            isEmpty = false;
            entity = 0;  //player = 0
            EventManager.OnChangeTurn((int) GameManager.EntityTurn.enemy);
        }
        else
        {
            imag.sprite = aISprite;
            isEmpty = false;
            entity = 1; // enemy = 1
            EventManager.OnChangeTurn((int)GameManager.EntityTurn.player);
        }
    }

}
