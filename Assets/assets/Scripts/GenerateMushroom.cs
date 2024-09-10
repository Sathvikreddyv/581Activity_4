using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateMushroom : MonoBehaviour
{
    public GameObject mushroom;

    private GameObject mushroomPrefab;

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
        yRange = Random.Range(-3, 10);
        timeElapsed += Time.deltaTime;
        //timeChecker = timeElapsed%5;
        SpawnGap = Random.Range(5, 10);
        if (timeElapsed - Time.deltaTime > SpawnGap)
        {
            //Debug.Log("Spawned");
            MushroomSpawn();
            timeElapsed = 0;
        }
    }

    public void MushroomSpawn()
    {
        //Debug.Log("Spawned");
        mushroomPrefab = Instantiate(mushroom, new Vector3(28.02f, yRange, 0f), mushroom.transform.rotation);
    }
}
