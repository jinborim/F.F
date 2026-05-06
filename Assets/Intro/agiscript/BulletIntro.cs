using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletIntro : MonoBehaviour
{
    public float speed = 10f;
    public Autoshoot player;
    public Transform playerTransform;

    public Rigidbody2D bullet;

    void Start()
    {
        player = GameObject.FindObjectOfType<Autoshoot>();
        playerTransform = player.transform;

        bullet = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        bullet = GetComponent<Rigidbody2D>();

        if (this.transform.position.x >  360)
        {
            Destroy(gameObject);
        }
        else
        {
            // Vector3.up = new Vector(0, 1, 0)
            /* this.transform.Translate(Vector3.right * this.speed * Time.deltaTime); */
            bullet.AddForce(Vector2.right * speed, ForceMode2D.Impulse);
        }


        
    }





}

