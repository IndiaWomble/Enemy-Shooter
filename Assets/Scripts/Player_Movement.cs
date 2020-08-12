using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour {

    public int speed = 10;
    public Pool p;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.A) && transform.position.x >= -10.0f)
            transform.position = new Vector2(transform.position.x - (speed * Time.deltaTime), transform.position.y);
        if (Input.GetKey(KeyCode.D) && transform.position.x <= 10.0f)
            transform.position = new Vector2(transform.position.x + (speed * Time.deltaTime), transform.position.y);
        if (Input.GetKeyDown(KeyCode.W))
            p.Spawn();
    }
}
