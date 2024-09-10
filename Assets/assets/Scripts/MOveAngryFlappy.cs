using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOveAngryFlappy : MonoBehaviour
{
    public int angryFlapppySpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        angryFlapppySpeed = Random.Range(20,50);
        transform.position += Vector3.left * angryFlapppySpeed * Time.deltaTime;
    }
}
