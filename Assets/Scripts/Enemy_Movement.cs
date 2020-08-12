using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Movement : MonoBehaviour {

    public int speed = 7;
    bool right = false;
    public Pool p;
    public float repeat = 1.0f;

	// Use this for initialization
	void Start () {
        InvokeRepeating("Spawner", 0.1f, repeat);
	}
	
	// Update is called once per frame
	void Update () {
        if (!right)
        {
            transform.position = new Vector2(transform.position.x + (speed * Time.deltaTime), transform.position.y);
            if (transform.position.x >= 10.5f)
                right = true;
        }   
        else if (right)
        {
            transform.position = new Vector2(transform.position.x - (speed * Time.deltaTime), transform.position.y);
            if (transform.position.x <= -10.5f)
                right = false;
        }
    }

    void Spawner()
    {
        p.Spawn();
    }
}
