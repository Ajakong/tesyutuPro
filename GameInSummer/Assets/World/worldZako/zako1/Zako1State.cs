using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Zako1State : MonoBehaviour
{

    int Hp;
    int PostHp;
    int furyGage;
    

    public bool modeFury;
    // Start is called before the first frame update
    void Start()
    {
        PostHp = 0;
        Hp = 40;
        furyGage = 0;
        modeFury = false;
    }

    // Update is called once per frame
    void Update()
    {
        PostHp = Hp;
        if(Hp==0)
        {

            //�������o
            SceneManager.LoadScene("world" + "Scene");
        }
        if(furyGage==200)
        {
            //���[�h�ڍs
            modeFury = true;
        }
        Debug.Log(Hp);
        if(PostHp==Hp)
        {
            //�U���󂯂����o
        }
    }
    public int hpMove
    {
        get { return Hp; }
        set { Hp = value; }
    }
}
