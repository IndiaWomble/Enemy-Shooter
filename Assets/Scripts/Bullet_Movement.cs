using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Movement : MonoBehaviour {

    public int speed = 10;
    bool player;
    public Pool p1, p2;

	// Use this for initialization
	void Start () {
        if (transform.position.y < 0.0f)
            player = true;
        if (transform.position.y > 0.0f)
            player = false;

	}
	
	// Update is called once per frame
	void Update () {
        if (player)
            transform.position = new Vector2(transform.position.x, transform.position.y + (speed * Time.deltaTime));
        else if(!player)
            transform.position = new Vector2(transform.position.x, transform.position.y - (speed * Time.deltaTime));
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("UpperLimit"))
            p1.BackToList(gameObject);
        else if (collision.gameObject.CompareTag("LowerLimit"))
            p2.BackToList(gameObject);
        else if (collision.gameObject.CompareTag("Enemy"))
            Debug.Log("EnemyEnd");
        else if (collision.gameObject.CompareTag("Player"))
            Debug.Log("PlayerEnd");
    }
}
