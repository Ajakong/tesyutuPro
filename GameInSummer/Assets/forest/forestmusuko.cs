using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forestmusuko : MonoBehaviour
{


    EnemyState enel;


    int hp = 0;

    public string targetObjectName;
    // Start is called before the first frame update
    void Start()
    {
        this.enel = FindObjectOfType<EnemyState>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)                 // �����蔻����@�m
    {
        if (collision.gameObject.name == targetObjectName)
        {

            //int hp = enel.hpMove;

            enel.hpMove -= 20;
            if (enel.hpMove == 0)
            {
                hp = 0;
            }
        }
    }
}


