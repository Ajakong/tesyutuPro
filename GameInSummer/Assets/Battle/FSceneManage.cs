using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSceneManage : MonoBehaviour
{
    GameObject player;
    PlayerMove yer;


    Vector3 pos = new Vector3();
    // Start is called before the first frame update
    void Start()
    {
        this.yer = FindObjectOfType<PlayerMove>();
        player = GameObject.Find("player");
        //Debug.Log("“®‚¢‚Ä‚é‚æ");
        pos = player.transform.position;

        pos = new Vector3(0, 2, 0);
        player.transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {   
        yer.areaMove = 2;
    }
        
}
