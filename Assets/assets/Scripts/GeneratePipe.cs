using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePipe : MonoBehaviour
{
    public float PipeSpawnCountdown;
    public float PipeSpawnInterval = 2f;

    public GameObject TopPipe;
    public GameObject BottomPipe;
    public GameObject Coin;
    public GameObject PLant;
    private GameObject TopPipePrefab;
    private GameObject BottomPipePrefab;
    private GameObject CoinPrefab;
    private GameObject PlantPrefab;

    private int TopYRange;
    private int BottomYRange;
    private float TimeElapsed;
    private int GeneratePlant;

    public MovePipe movepipe;
    public MovePipe moveThePipe;
    public MovePipe moveCoins;

    private float TImeChecker;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TImeChecker += Time.deltaTime;
        GeneratePlant = Random.Range(0, 5);
        TimeElapsed += Time.deltaTime;
        ConstructPipe();

        if(TImeChecker - Time.deltaTime > 15)
        {
            PipeSpawnInterval = 1.5f;
        }
    }

    public void ConstructPipe()
    {
        PipeSpawnCountdown -= Time.deltaTime;
        if (PipeSpawnCountdown <= 0)
        {
            PipeSpawnCountdown = PipeSpawnInterval;
            BottomYRange = Random.Range(-8, 6);
            TopYRange = BottomYRange + Random.Range(5, 11);
            TopPipePrefab = Instantiate(TopPipe, new Vector3(28.02f, TopYRange, 0), TopPipe.transform.rotation);
            BottomPipePrefab = Instantiate(BottomPipe, new Vector3(28.02f, BottomYRange, 0), BottomPipe.transform.rotation);
            CoinPrefab = Instantiate(Coin, new Vector3(28.02f, 0.5f*(BottomYRange+TopYRange), 0), Coin.transform.rotation);

            if (GeneratePlant == 1)
            {
                if (TimeElapsed - Time.deltaTime > 7)
                {
                    PlantPrefab = Instantiate(PLant, new Vector3(BottomPipePrefab.transform.position.x, BottomPipePrefab.transform.position.y-1, BottomPipePrefab.transform.position.z), PLant.transform.rotation);
                }
            }
        }
    }
}
