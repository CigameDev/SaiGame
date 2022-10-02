using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DamageSender : MonoBehaviour
{
    [SerializeField]protected EnemyController enemyController;
    private void Awake()
    {
        this.enemyController = GetComponent<EnemyController>();
        
    }
    private void OnTriggerEnter2D(Collider2D collision)//gan rigidbody2d cho enemy
    {
        //Debug.Log(collision.name);
        DamageReceiver shot = collision.GetComponent<DamageReceiver>();
        if (shot != null)
        {
            collision.GetComponent<DamageReceiver>().Receiver(1);//tai sao khong lien ket cai nay vao enemyController
            this.enemyController.deSpawner.Despawn();                                                  //collision chinh la Player ,lay script nhan sat thuong ,goi ham receiver(Nhan sat thuong)
        }
        /*
         Noi chung can kiem tra xem co dung 2 doi tuong do va cham voi nhau khong
         vi 2 doi tuong gan Boxcollider deu co the va cham,vi du nhu truong hop nay
        2 enemy co the va cham voi nhau ,ma ta can enemy va cham voi player ,2 enemy va cham voi nhau cung
        kich hoat Ontrigger nen khong co thuoc tinh DamageReceiver ,dan den bi null
        ta can kiem tra xem co dung doi tuong va cham khong truoc khi cho thuc hien va cham
         */
    }
}
