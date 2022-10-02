using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerPosition : MonoBehaviour
{
    private int count = 0;
    
    List<GameObject> boms;
    public GameObject bomPrefab;
    protected float spawnTimer = 0f;
    protected float spawnDelay = 1f;

    void Start()
    {
        boms = new List<GameObject>();
    }

    
    void Update()
    {
        this.Spawn();
       
        CheckMinionDead();
    }
    void Spawn()
    {
        this.spawnTimer += Time.deltaTime;
        if (this.spawnTimer < this.spawnDelay) return;
        this.spawnTimer = 0f;

        if (this.boms.Count >= 7) return;
        
        GameObject bom = Instantiate(this.bomPrefab);
        bom.name = "bom " + (++count);

        bom.gameObject.SetActive(true);
        this.boms.Add(bom);
        bom.transform.position = this.transform.position;
    }
    
    void CheckMinionDead()
    {
        GameObject bom;
        for(int i=0;i<this.boms.Count;i++)
        {
            bom = this.boms[i];
            if (bom == null) this.boms.RemoveAt(i);
        }    
    }    
}
