using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickUpgrade2 : MonoBehaviour
{
    float cost = 20;

    public Text costText;

    private void Start()
    {

    }
    public void Clicked()
    {
        if (cost <= GameManager.hits)
        {
            CloseButton.clickValue += 1;
            GameManager.hits -= (int)cost;
            cost += cost * 0.5f;

            Updatetext();
        }
        else
        {
            Debug.Log("Can't afford");
        }
    }

    void Updatetext()
    {
        costText.text = "MEGA Slaps - " + cost.ToString("0");
    }

}
