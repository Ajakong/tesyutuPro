using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forestEnel : MonoBehaviour
{
    GameObject miasma;
    GameObject bullet;

    int attackRC;

    int attackJudge;


    // Start is called before the first frame update
    void Start()
    {
        miasma = GameObject.Find("Circle");
        miasma.SetActive(false);

        bullet = GameObject.Find("Bullet");
        bullet.SetActive(false);

        attackRC = 0;


        attackJudge = 1;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        if (attackRC > 200)
        {
            attackJudge = Random.Range(0, 4);
            switch (attackJudge)
            {
                case 0:
                    {

                        miasma.SetActive(true);
                        attackRC = 0;
                        break;
                    }
                //case 1:
                //    {
                //        bullet.SetActive(true);
                //        attackRC = 0;
                //        break;
                //    }


            }

        }
        attackRC++;
    }
}
