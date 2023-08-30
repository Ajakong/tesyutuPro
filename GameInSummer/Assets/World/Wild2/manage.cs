using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manage : MonoBehaviour
{
    PlayerMove yer;
    // Start is called before the first frame update
    void Start()
    {
        this.yer = FindObjectOfType<PlayerMove>();
    }

    // Update is called once per frame
    void Update()
    {
        yer.areaMove = 1;
    }
}

