using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public float maxTime;
    private float timer = 0;
    public GameObject Obstacle;
    public float height;

    void Update()
    {
        if (timer > maxTime)
        {
            GameObject pipe = Instantiate(Obstacle);
            pipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, +height));
            Destroy(pipe, 5);

            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
