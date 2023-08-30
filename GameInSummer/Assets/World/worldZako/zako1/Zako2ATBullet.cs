using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zako2ATBullet : MonoBehaviour
{
    [SerializeField] private Transform playerTrans; //�ǂ�������Ώۂ�Transform
    [SerializeField] private float bulletSpeed;  �@ //�e�̑��x
    [SerializeField] private float limitSpeed;      //�e�̐������x
    private Rigidbody2D rb;                         //�e��Rigidbody2D
    private Transform bulletTrans;

    public string targetObjectName;//�e��Transform

    private void Start()
    {
        transform.Translate(9, 0, 0);
    }
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        bulletTrans = GetComponent<Transform>();
    }

    private void FixedUpdate()
    {
        Vector3 vector3 = playerTrans.position - bulletTrans.position;  //�e����ǂ�������Ώۂւ̕������v�Z
        rb.AddForce(vector3.normalized * bulletSpeed);                  //�����̒�����1�ɐ��K���A�C�ӂ̗͂�AddForce�ŉ�����

        float speedXTemp = Mathf.Clamp(rb.velocity.x, -limitSpeed, limitSpeed);�@//X�����̑��x�𐧌�
        float speedYTemp = Mathf.Clamp(rb.velocity.y, -limitSpeed, limitSpeed);  //Y�����̑��x�𐧌�
        rb.velocity = new Vector3(speedXTemp, speedYTemp);�@�@�@�@�@�@�@�@�@�@�@//���ۂɐ��������l����
    }

    private void OnTriggerEnter2D(Collider2D collision)                 // �����蔻����@�m
    {

        if (collision.gameObject.name == targetObjectName)
        {
            this.gameObject.SetActive(false);
        }
        if (collision.gameObject.name == "stage (1)")
        {
            Destroy(this.gameObject);
        }
        
    }
}
