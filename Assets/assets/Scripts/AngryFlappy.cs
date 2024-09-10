using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngryFlappy : MonoBehaviour
{
    public GameObject angryFlappy;
    private GameObject angryFlappyPrefab;

    public int yRange;
    public float timeElapsed;
    public float timeChecker;
    private float SpawnGap;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        yRange = Random.Range(-8, 12);
        timeElapsed += Time.deltaTime;
        //timeChecker = timeElapsed%5;
        SpawnGap = Random.Range(3, 8);
        if (timeElapsed-Time.deltaTime > SpawnGap)
        {
            //Debug.Log("Spawned");
            SpawnAngryBird();
            timeElapsed= 0;
        }
    }

    public void SpawnAngryBird()
    {
        //Debug.Log("Spawned");
        angryFlappyPrefab = Instantiate(angryFlappy, new Vector3(28.02f, yRange, 0f), angryFlappy.transform.rotation);
    }
}
