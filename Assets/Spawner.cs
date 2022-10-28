using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public float maxTime = 1;
    private float timer = 0;
    public GameObject monster;
    public float height;
    // Start is called before the first frame update
    void Start()
    {
        GameObject newmonster = Instantiate(monster);
        newmonster.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
            GameObject newmonster = Instantiate(monster);
            newmonster.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newmonster, 6);
            timer = 0;
        }
        timer += Time.deltaTime;

    }
}
