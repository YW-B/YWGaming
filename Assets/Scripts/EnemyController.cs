using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public float maxspeed = 2;
    public int damage = 1;
    public SpriterRenderer sr;
    
    void Start()
    {
        sr = GetComponent<SpriterRenderer>();

        
    }

    public void flip(){

        sr.flipX = !sr.flipX;
    }

    void OnTriggerEnter2D(Collider2D other)
{
    if (other.tag == "Player")
    {
        FindObjectOfType<PlayerStats>().TakeDamage(damage);
        Flip();
    }
    else if (other.tag == "Wall")
    {
        Flip();
    }
}



    // Update is called once per frame
    void Update()
    {
        
    }
}
