using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSceneManage : MonoBehaviour
{
    GameObject player;
    PlayerMove yer;

    static public int flag=0;

    Vector3 pos = new Vector3();
    // Start is called before the first frame update
    void Awake()
    {
        if (flag == 1)
        { 
        this.yer = FindObjectOfType<PlayerMove>();
        player = GameObject.Find("player");
        //Debug.Log("“®‚¢‚Ä‚é‚æ");
        pos = player.transform.position;

        pos = new Vector3(0, 2, 0);
        player.transform.position = pos;
        }
        flag = 0;
    }

    // Update is called once per frame
    void Update()
    {   
        yer.areaMove = 2;
    }

    public static int flagMove
    {
        get { return flag; }
        set { flag = value; }
    }

}
