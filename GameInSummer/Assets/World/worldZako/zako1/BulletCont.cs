using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCont : MonoBehaviour
{
    Vector3 move;
    Vector3 reset;

    int timer;
    public string target;

    
    private void Start()
    {
        move = new Vector3(-0.2f, 0, 0);
        reset = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
       if(timer>300)
        {
            transform.position = reset;
            this.gameObject.SetActive(false);
        }
        transform.position += move;
    }

    private void FixedUpdate()
    {
        timer++;
    }

    private void OnTriggerEnter2D(Collider2D collision)                 // “–‚½‚è”»’è‚ðŽ@’m
    {

        if (collision.gameObject.name == target)
        {
            Debug.Log("hit");
            transform.position = reset;
            this.gameObject.SetActive(false);
        }
        
        
    }
}
