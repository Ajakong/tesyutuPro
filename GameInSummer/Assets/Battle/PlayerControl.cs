using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;


[RequireComponent(typeof(Animator))]
public class PlayerControl : MonoBehaviour
{

    GameObject musuko;



    //Animator anim;
    //[SerializeField] AudioSource Dush;

    public float Speed = 0;   // �v���C���[�ړ����x
    public float Jump = 0;   //�W�����v�̃p���[
    bool GravityFall;

    Rigidbody2D rbody;


    public bool JumpFlag = false;
    public bool GroundFlag = false;
    public bool TurnFlag = false;
    public bool flagAttack=true;

    private bool IsMoving = false;

    int attackTimer;

    void Start()
    {
        
        musuko = GameObject.Find("bakamusuko");
        musuko.SetActive(false);

        //anim = GetComponent<Animator>();
        //anim.SetBool("IsMoving", false);
        rbody = GetComponent<Rigidbody2D>();
        rbody.gravityScale = 3;
        rbody.constraints = RigidbodyConstraints2D.FreezeRotation;
        GravityFall = false;
        attackTimer = 20;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            
            JumpFlag = true;
        }
        if(GravityFall)
        {
            transform.Translate(0, 0, 0);
            GravityFall =false;

        }
        if(!GravityFall)
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

       
    }

    void FixedUpdate()
    {
        // �E���ŉE�ړ�
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Speed += 0.5f;
            TurnFlag = false;


        }
        //�����ō��ړ�
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

        //�U��
        if (Input.GetKey(KeyCode.W) && flagAttack == true)
        {
            attackTimer = 0;

            
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
}
