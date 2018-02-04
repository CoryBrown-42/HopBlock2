using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBox : MonoBehaviour {
    public GameObject player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector2 toTarget = player.transform.position - transform.position;
        float speed = 1.5f;

        transform.Translate(toTarget * speed * Time.deltaTime);
    }
}
