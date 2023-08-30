using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigEnemy : MonoBehaviour
{
    GameObject sword;

    bool attackFlag=false;

    int timer;
    // Start is called before the first frame update
    void Start()
    {
        sword = GameObject.Find("Sword");
        sword.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(timer>400)
        {
            attackFlag = true;
            timer = 0;
        }
        if(attackFlag)sword.SetActive(true);
    }

    private void FixedUpdate()
    {
        timer++;
    }
}
