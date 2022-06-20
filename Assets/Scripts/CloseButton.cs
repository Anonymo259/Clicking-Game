using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseButton : MonoBehaviour
{
    public Animator anim;

    public static int clickValue = 1;
     
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    public void Clicked()
    {
        anim.SetTrigger("Slapped");

        GameManager.hits += clickValue;
        Debug.Log(GameManager.hits);
    }

   
}
