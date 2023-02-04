using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootSystemController : MonoBehaviour
{
    public GameObject[] rootPrefabs;


    // Start is called before the first frame update
    void Start()
    {
        float xStart = -20f;
        float zStart = -20f;
        int xQuads = 8;
        int zQuads = 8;

        for (int i = 0; i < xQuads; i++)
        {
            for (int j = 0; j < zQuads; j++)
            {
                float xPos = xStart + i * 5f + Random.RandomRange(0f, 5f);
                float zPos = zStart + j * 5f + Random.RandomRange(0f, 5f);
                GameObject root = RandomRoot();
                Instantiate(root, new Vector3(xPos, 49, zPos), root.transform.rotation);
            }
        }

    }

    GameObject RandomRoot()
    {
        return rootPrefabs[Random.Range(0, rootPrefabs.Length)];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
