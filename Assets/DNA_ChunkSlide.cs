using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DNA_ChunkSlide : MonoBehaviour {

    Rigidbody2D rb;
    public float speed = -1.0f;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        rb.velocity = new Vector2(speed, rb.velocity.y);
    }
}
