using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageReceiver : MonoBehaviour
{
    [SerializeField]protected int hp = 10;//blood
   
    public virtual bool IsDead()
    {
        return hp <= 0;
    }
    public virtual void Receiver(int damage)
    {
        hp -= damage;
    }
}
