using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//cu moi lan bi giam damage thi moi kiem tra de nang hieu suat
//script nay chi lam nhiem vu giam damage cho player thoi
public class PlayerDamageReceiver : DamageReceiver
{
    [SerializeField]protected  PlayerController playerController;
    

    private void Awake()
    {
        this.playerController = GetComponent<PlayerController>();
        
    }
    public override void Receiver(int damage)
    {
        base.Receiver(damage);
        if(this.IsDead())
        {
            this.playerController.playerStatus.Dead();
        }
    }
}
