using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float speed;
    private float ttl;
    private float time;
    
    public void SetBullet(float bulletSpeed, float bulletTime)
    {
        speed = bulletSpeed;
        ttl = bulletTime;
        time = 0;
    }
    
    void Update()
    {
        time += Time.deltaTime;
        if (time >= ttl)
        {
            Destroy(gameObject);
        }
        
        //TODO : move bullet forward
    }
}
