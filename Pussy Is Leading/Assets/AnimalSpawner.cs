using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSpawner : MonoBehaviour
{
    public Transform spawnPos;
    public GameObject spawnee;
    public int count;

    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (count <= 60)
            {
                count++;
                Instantiate(spawnee, spawnPos.position, spawnPos.rotation);
            }
        }
    }
}
