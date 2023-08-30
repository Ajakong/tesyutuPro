using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zako2ATBullet : MonoBehaviour
{
    [SerializeField] private Transform playerTrans; //追いかける対象のTransform
    [SerializeField] private float bulletSpeed;  　 //弾の速度
    [SerializeField] private float limitSpeed;      //弾の制限速度
    private Rigidbody2D rb;                         //弾のRigidbody2D
    private Transform bulletTrans;

    public string targetObjectName;//弾のTransform

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
        Vector3 vector3 = playerTrans.position - bulletTrans.position;  //弾から追いかける対象への方向を計算
        rb.AddForce(vector3.normalized * bulletSpeed);                  //方向の長さを1に正規化、任意の力をAddForceで加える

        float speedXTemp = Mathf.Clamp(rb.velocity.x, -limitSpeed, limitSpeed);　//X方向の速度を制限
        float speedYTemp = Mathf.Clamp(rb.velocity.y, -limitSpeed, limitSpeed);  //Y方向の速度を制限
        rb.velocity = new Vector3(speedXTemp, speedYTemp);　　　　　　　　　　　//実際に制限した値を代入
    }

    private void OnTriggerEnter2D(Collider2D collision)                 // 当たり判定を察知
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
