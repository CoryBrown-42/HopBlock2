using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {


    Rigidbody2D rb;
    public Transform groundCheck;
    public float groundCheckRadius;

    public LayerMask groundIsWhere;

    bool onGround;

	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        onGround = Physics2D.OverlapCircle(groundCheck.position,
            groundCheckRadius, groundIsWhere);

        rb.velocity = new Vector2(3, rb.velocity.y);

        if(Input.GetMouseButton(0) && onGround)
        {
            rb.velocity = new Vector2(rb.velocity.x, 5);
        }
	}

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            rb.transform.position = new Vector2(-2, 2);
        }

        if (col.gameObject.tag == "KillBox")
        {
            //Destroy(gameObject);
            gameObject.SetActive(false);
            SceneManager.LoadScene(2);
        }
        if (col.gameObject.tag == "Bricks")
        {
            //Destroy(gameObject);
            gameObject.SetActive(false);
            SceneManager.LoadScene(2);
        }
    }
}
