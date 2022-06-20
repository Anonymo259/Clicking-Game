using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static int hits;
    public Text counterText;
    public GameObject Upgrade2;
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        counterText.text = hits + "hits";
        if (hits > 20)
        {
            Upgrade2.SetActive(true);
        }
    }
}
