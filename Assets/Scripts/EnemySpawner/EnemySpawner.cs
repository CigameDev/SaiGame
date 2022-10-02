using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] protected GameObject enemyPrefab;
    protected float timer = 0;
    protected float delay = 2f;
    private void Awake()
    {
        this.enemyPrefab = GameObject.Find("EnemyPrefab");//day la 1 cach lien ket khac vi ta biet chac ten la EnemyPrefab roi
        this.enemyPrefab.SetActive(false);
    }

    private void Update()
    {
        this.Spawn();
    }
    protected virtual void Spawn()
    {
        this.timer +=Time.deltaTime;
        if (this.timer < delay) return;
        this.timer = 0;
        GameObject enemy = Instantiate(enemyPrefab);
        enemy.SetActive(true);
        enemy.transform.position = this.transform.position;//sinh ra o vi tri cua enemySpawner
    }
}
