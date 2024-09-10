using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePipe : MonoBehaviour
{
    public float pipeSpeed = 5;
    public happyFlappy CheckTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * pipeSpeed * Time.deltaTime;
        //if(CheckTime.TimeChecker > 15f)
        //{
        //    pipeSpeed += 5f;
        //}
    }
}
