using JetBrains.Annotations;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class happyFlappy : MonoBehaviour
{
    public float gravity = 30f;
    public float jumpForce = 10f;
    private float verticalSpeed;
    public float diveForce = 15f;
    public float rotationSpeed = 30f;  // Speed of rotation
    public float TimeElapsed=0;
    public float TimeChecker;

    private Coroutine Cooldown;

    public GameObject bird;
    public GameObject birdBody;
    public GameObject birdwings;

    public Image power;
    private void Start()
    {
        birdBody.GetComponent<Renderer>().material.color = Color.yellow;
        birdwings.GetComponent<Renderer>().material.color = Color.yellow;
    }

    // Update is called once per frame
    void Update()
    {
        TimeChecker = Time.deltaTime;
        TimeElapsed += Time.deltaTime;
        if(Input.GetKeyDown(KeyCode.DownArrow) && TimeElapsed > 5f)
        {
            bird.GetComponent<BoxCollider>().enabled = false;
            TimeElapsed = 0;
            power.color= Color.gray;
            birdBody.GetComponent<Renderer>().material.color = Color.gray;
            birdwings.GetComponent<Renderer>().material.color = Color.gray;
        }

        if (TimeElapsed > 3f)
        {
            bird.GetComponent<BoxCollider>().enabled = true;
            birdBody.GetComponent<Renderer>().material.color = Color.yellow;
            birdwings.GetComponent<Renderer>().material.color = Color.yellow;
        }

        if(TimeElapsed > 5f)
        {
            power.color = Color.white;
        }

        // Apply gravity
        verticalSpeed -= gravity * Time.deltaTime;

        // Flap when Space key is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            verticalSpeed = jumpForce;
            RotateBirdSmoothly(30f);  // Rotate bird smoothly when flapping
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            RotateBirdSmoothly(-30f);  // Rotate bird smoothly when releasing Space key
        }

        // Move the bird
        bird.transform.position += Vector3.up * verticalSpeed * Time.deltaTime;
    }

    // Function to rotate the bird smoothly
    void RotateBirdSmoothly(float targetAngle)
    {
        bird.transform.LeanRotateZ(targetAngle, 0.1f);
    }
}
