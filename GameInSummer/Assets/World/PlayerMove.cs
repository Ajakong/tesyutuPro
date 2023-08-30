using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    int encount;

    float speed;

    bool moveFlag = false;
    public int DDOLFlag; 

    public bool encountFlag;
    int encountCharge;
    int postEncountCharge;

    public int areaNum;

    public string emptyObj;
    public string emptyObj2;

    Vector3 enPos = new Vector3();

    // Start is called before the first frame update
    void Start()
    {
        DDOLFlag = 0;
        DontDestroyOnLoad(this.gameObject);
        enPos = Vector3.zero;
        
        speed = 0.05f;
        encountFlag = false;
        encountCharge=0;
        postEncountCharge=0;
        areaNum = 5;
        

    }

    // Update is called once per frame
    void Update()
    {

        //Debug.Log(encountCharge);
        //移動
        Vector3 position = transform.position;
        
        if (encountCharge == 0)
        {
            
             position=enPos;
        }
        transform.position = enPos;
        if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.RightArrow))
        {
            speed = 0.025f;
            //encountCharge++;
            moveFlag = true;
        }
        if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.RightArrow))
        {
            speed = 0.025f;
            //encountCharge++;
            moveFlag = true;
        }
        if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftArrow))
        {
            speed = 0.025f;
            //encountCharge++;
            moveFlag = true;
        }
        if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.LeftArrow))
        {
            speed = 0.025f;
            //encountCharge++;
            moveFlag = true;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            position.y += speed;
            //position.z += speed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            position.y -= speed;
            //position.z -= speed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            position.x += speed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            position.x -= speed;
        }


        if(speed==0)
        {
            moveFlag = false;
        }
        transform.position = position;
        speed = 0.05f;



        

        //マップ移動
        if(transform.position.y > 9)
        {
            areaNum = 2;
                   }
        if (transform.position.y > 50)
        {
            areaNum = 3;
           
        }


    }

    private void FixedUpdate()
    {
        if(moveFlag==true)
        {
            encountCharge++;
        }
        //エンカウント処理

        if (encountCharge > 200)
        {
            postEncountCharge = encountCharge;

            encount = Random.Range(0, 200);

            Debug.Log(encount);
            if (encount == 1)
            {
                encountCharge = 0;
                if(areaNum == 0)
                {
                    enPos = transform.position;
                    Debug.Log("入れました");
                    SceneManager.LoadScene("battle" + "Scene");
                }
                if (areaNum == 1)
                {
                    enPos = transform.position;
                    Debug.Log("入れました");
                    SceneManager.LoadScene("world" + "Zako");
                }
                if (areaNum == 2)
                {
                    enPos = transform.position;
                    Debug.Log("入れました");
                    SceneManager.LoadScene("forestshadow");
                }
            }
        }
    }

    public int areaMove
    {
        get { return areaNum; }
        set { areaNum= value; }
    }








}
