using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ESwordMove : MonoBehaviour
{

    Vector3 axis;       // ‰ñ“]Ž²
    Vector3 point;

    int timer;

    public float SpinLot;

    public float move;

    Quaternion q;


    // Start is called before the first frame update
    void Start()
    {
        SpinLot = 0.45f;
        timer = 0;
        move = 0.1f;

        point = new Vector3(-move, -move, 0f);
        axis = new Vector3(0f, 0f, 1f);
        q = Quaternion.AngleAxis(2f, axis);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        timer++;

        this.transform.rotation = this.transform.rotation * q;
        this.transform.position += point;
        if (50 < timer)
        {
            Destroy(this);
        }
    }
}
