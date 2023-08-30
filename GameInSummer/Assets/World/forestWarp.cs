using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class forestWarp : MonoBehaviour
{
    

    public string targetObj;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerStay2D(Collider2D collision)                 // “–‚½‚è”»’è‚ðŽ@’m
    {
        if (collision.gameObject.name == targetObj)
        {
            
            FSceneManage.flagMove = 1;
            SceneManager.LoadScene("forest");
        }
    }
}
