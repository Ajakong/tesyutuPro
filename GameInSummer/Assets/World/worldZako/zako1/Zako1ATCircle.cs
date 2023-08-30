using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zako1ATCircle : MonoBehaviour
{
    Vector3 localScale;
    Vector3 reScale;
    Vector3 Move;

    int timer;
    // Start is called before the first frame update
    void Start()
    {
        localScale = transform.localScale;
        reScale = localScale;
        Move = new Vector3(0.15f, 0.15f, 0);

        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if(timer<50)
        {
            localScale += Move;
        }
        if(timer>60)
        {
            timer = 0;
            localScale = reScale;
            Debug.Log("è¡Ç¶ÇΩ");
            this.gameObject.SetActive(false);
        }

        transform.localScale = localScale;
        timer++;
    }
}
