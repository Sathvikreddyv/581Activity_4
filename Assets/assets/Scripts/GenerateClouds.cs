using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateClouds : MonoBehaviour
{
    public GameObject Clouds;
    private GameObject CloudsPrefab;

    public float CloudsSpawnCountdown;
    public float CloudsSpawnInterval = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ConstructClouds();
    }

    public void ConstructClouds()
    {
        CloudsSpawnCountdown -= Time.deltaTime;
        if (CloudsSpawnCountdown <= 0)
        {
            CloudsSpawnCountdown = CloudsSpawnInterval;
            CloudsPrefab = Instantiate(Clouds, transform.position, transform.rotation);
        }
    }
}
