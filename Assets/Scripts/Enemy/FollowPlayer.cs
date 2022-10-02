using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private Transform player;
    protected float speed = 7f;
    protected float disLimit = 0.5f;
    void Start()
    {
        
    }

    
    void Update()
    {
        //this.Follow();
        Invoke("Follow", 2f);//2s sau Enemy m?i b?t ??u follow theo Player
    }
    void Follow()
    {
        Vector3 distance = this.player.position - transform.position;
        if (distance.magnitude >= disLimit)
        {
            Vector3 targetPoint = this.player.position - distance.normalized * this.disLimit;
            gameObject.transform.position =
                Vector3.MoveTowards(gameObject.transform.position, targetPoint, speed * Time.deltaTime);
        }
    }    
}
