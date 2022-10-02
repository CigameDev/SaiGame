using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public DeSpawner deSpawner;
    void Start()
    {
        this.deSpawner = GetComponent<DeSpawner>();//tao lien ket trong realtime
    }

    
}
