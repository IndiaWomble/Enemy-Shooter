using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pool : MonoBehaviour {

    public List<GameObject> pool;
    public int size = 20;
    public GameObject obj;
    public Transform spawnPosition;

	// Use this for initialization
	void Start () {
		for(int i = 0; i < size; i++)
        {
            var o = Instantiate<GameObject>(obj, spawnPosition.position, Quaternion.identity);
            o.SetActive(false);
            pool.Add(o);
        }
	}
	
	// Update is called once per frame
	void Update () {

	}

    public void Spawn()
    {
        pool[0].transform.position = spawnPosition.position;
        pool[0].SetActive(true);
        pool.RemoveAt(0);
    }

    public void BackToList(GameObject g)
    {
        g.SetActive(false);
        pool.Add(g);
    }
}
