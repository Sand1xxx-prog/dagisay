using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    public float maxHealth = 100;
    public float currHealth = 100;
    public Rigidbody2D rb;
    public float jumpForce = 7000f;
    public float speed = 5f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (currHealth > 0)
        {
            float moveX = Input.GetAxis("Horizontal");
            rb.MovePosition(rb.position + Vector2.right * moveX * speed * Time.deltaTime);

            if (Input.GetKey(KeyCode.W))
            {
                rb.AddForce(Vector2.up * jumpForce);
            }
            if (Input.GetKey(KeyCode.S))
            {
                rb.AddForce(Vector2.down * jumpForce);
            }
        }
        else
        {
            SceneManager.LoadScene("Proigrish");
        }
        
    }
}