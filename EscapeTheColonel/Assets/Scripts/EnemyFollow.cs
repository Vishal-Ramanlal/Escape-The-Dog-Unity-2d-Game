using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    Rigidbody2D rigidbody2D;

    public float speed;
    private Transform target;
    public MainCharacterScript player;

    Animator animator; 
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        player = player.GetComponent<MainCharacterScript>();

        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        animator = GetComponent<Animator>();
            
    }

    // Update is called once per frame
    void Update()
    {
        if (!player.gameOver)
        {
            Vector2 pos = rigidbody2D.position;
            
            rigidbody2D.position = Vector2.MoveTowards(rigidbody2D.position, target.position, speed * Time.deltaTime);

            //Debug.Log("sd: " + pos.x + " " + rigidbody2D.position.x);
            if(pos.x > rigidbody2D.position.x)
            {
                animator.SetFloat("Move X", -0.5f);
                animator.SetFloat("Move Y", 0f);
            }
            else
            {
                animator.SetFloat("Move X", 0.5f);
                animator.SetFloat("Move Y", 0f);
            }
           
        }
        else
        {

        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        MainCharacterScript player = other.gameObject.GetComponent<MainCharacterScript>();

        if (player != null)
        {
            player.changeHealth(-1);
        }
    }
  
}

