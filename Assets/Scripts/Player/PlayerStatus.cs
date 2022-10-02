using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    [SerializeField] protected PlayerController playerController;

    private void Awake()
    {
        playerController = GetComponent<PlayerController>();
    }

    private void Update()
    {
        //this.CheckDead();
    }
    protected  virtual void CheckDead()
    {
        if(this.playerController.damageReceiver.IsDead())
        {
            this.Dead();//log ra chu dead thoi
        }
    }

    public virtual void Dead()
    {
        Debug.Log("Dead");
    }
}
