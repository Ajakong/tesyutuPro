using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Animator))]
public class PlayerControl : MonoBehaviour
{

    GameObject musuko;

    private AudioSource audioSource;


    //Animator anim;
    //[SerializeField] AudioSource Dush;

    public float Speed = 0;   // プレイヤー移動速度
    public float Jump = 0;   //ジャンプのパワー
    bool GravityFall;

    Rigidbody2D rbody;

    int hp;

    public bool JumpFlag = false;
    public bool GroundFlag = false;
    public bool TurnFlag = false;
    public bool flagAttack = true;

    private bool IsMoving = false;

    int attackTimer;

    public string target;
    void Start()
    {
        hp = 100;
        musuko = GameObject.Find("bakamusuko");
        musuko.SetActive(false);

        //anim = GetComponent<Animator>();
        //anim.SetBool("IsMoving", false);
        rbody = GetComponent<Rigidbody2D>();
        rbody.gravityScale = 3;
        rbody.constraints = RigidbodyConstraints2D.FreezeRotation;
        GravityFall = false;
        attackTimer = 20;

        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {

            JumpFlag = true;
        }
        if (GravityFall)
        {
            transform.Translate(0, 0, 0);
            GravityFall = false;

        }
        if (!GravityFall)
        {
            rbody.gravityScale = 5;
        }
        if (JumpFlag)
        {
            Jump = 3.0f;
            transform.Translate(0, Jump, 0);
            JumpFlag = false;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            GravityFall = true;
        }

        if(hp<=0)
        {
            SceneManager.LoadScene("Death");
        }

    }

    void FixedUpdate()
    {
        // 右矢印で右移動
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Speed += 0.5f;
            TurnFlag = false;


        }
        //左矢印で左移動
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Speed += -0.5f;
            TurnFlag = true;

        }
        if (this.gameObject.transform.position.x > 13f)
        {
            Speed -= 0.5f;
        }
        if (this.gameObject.transform.position.x < -13f)
        {
            Speed += 0.5f;
        }


        transform.Translate(Speed, 0, 0);
        if (Speed != 0)
        {
            //anim.SetBool("IsMoving", true);
        }
        else
        {

            //anim.SetBool("IsMoving", false);
        }
        //this.GetComponent<SpriteRenderer>().flipX = TurnFlag;
        Speed = 0;

        //攻撃
        if (Input.GetKey(KeyCode.W) && flagAttack == true)
        {
            attackTimer = 0;

            audioSource.Play();
            musuko.SetActive(true);
        }

        if (attackTimer < 40)
        {
            flagAttack = false;

        }
        else
        {
            flagAttack = true;

        }

        attackTimer++;

    }

    private void OnTriggerEnter2D(Collider2D collision)                 // 当たり判定を察知
    {
        if (collision.gameObject.name == target)
        {
            hp-=100;
        }
    }
}
