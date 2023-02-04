using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaindropSpawner : MonoBehaviour
{
    public GameObject raindrop;
    public float interval = 0.1f;

    private float nextActionTime = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        //
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextActionTime)
        {
            nextActionTime += interval;
            Instantiate(raindrop, gameObject.transform.position, Quaternion.identity);
        }
    }
}
