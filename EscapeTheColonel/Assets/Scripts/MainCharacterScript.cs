using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacterScript : MonoBehaviour
{
    public float speed = 3.0f;
    public float startingHealth = 1.0f;
    public float maxHealth = 10.0f;
    public float currentHealth;
    public GameObject Text;
    public GameObject gameOverMenu;

    Rigidbody2D rigidbody2d;
    Animator animator;
    internal bool gameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        gameOverMenu.SetActive(false);
        rigidbody2d = GetComponent<Rigidbody2D>();
        currentHealth = startingHealth;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.X))
        {
            
        }
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector2 position = rigidbody2d.position;
        position.x = position.x + speed * horizontal * Time.deltaTime;
        position.y = position.y + speed * vertical * Time.deltaTime;
        rigidbody2d.MovePosition(position);
        if (horizontal > 0)
        {
            animator.SetFloat("Move X", -0.5f);
            animator.SetFloat("Move Y", 0f);
        }
        else if(horizontal < 0)
        {
            animator.SetFloat("Move X", 0.5f);
            animator.SetFloat("Move Y", 0f);
        }
    }
    internal void changeHealth(float amount) {
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        
        
            Debug.Log("hi");
            gameOver = true;
        //Time.timeScale = 0;
        gameOverMenu.SetActive(true);

        //Debug.Log(currentHealth);
    }
    public void updateScore(int update)
    {
       Score s = Text.GetComponent<Score>();
        s.updateScore(update);
    }

}