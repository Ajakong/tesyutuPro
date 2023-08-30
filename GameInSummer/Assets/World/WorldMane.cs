using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldMane : MonoBehaviour
{
    GameObject Player;
    PlayerMove yer;
    // Start is called before the first frame update
    void Start()
    {
        this.yer = FindObjectOfType<PlayerMove>();
    }

    // Update is called once per frame
    void Update()
    {
        yer.areaMove = 0;
    }
}
