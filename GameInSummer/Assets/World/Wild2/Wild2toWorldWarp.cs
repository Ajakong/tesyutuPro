using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wild2toWorldWarp : MonoBehaviour
{
    GameObject player;

    Vector3 pos = new Vector3();

    public string targetObj;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerStay2D(Collider2D collision)                 // 当たり判定を察知
    {
        if (collision.gameObject.name == targetObj)
        {
            player = GameObject.Find("player");
            //Debug.Log("動いてるよ");
            pos = player.transform.position;

            pos = new Vector3(0, 3.5f, 0);
            player.transform.position = pos;
            SceneManager.LoadScene("worldScene");
        }
    }
}
