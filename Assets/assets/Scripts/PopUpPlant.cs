using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpPlant : MonoBehaviour
{
    public GameObject bottomPipe;
    public float movementSpeed = 5f;
    private Vector3 targetPos;

    private bool isMoving = false;

    void Update()
    {
        targetPos = new Vector3(bottomPipe.transform.position.x, bottomPipe.transform.position.y+1, bottomPipe.transform.position.z);
        if (isMoving)
        {

            // Calculate the distance to move this frame
            float step = movementSpeed * Time.deltaTime;

            // Move the object towards the target position
            transform.position = Vector3.MoveTowards(transform.position, targetPos, step);

            // Check if the object has reached the target position
            if (transform.position == targetPos)
            {
                isMoving = false;
            }
        }
    }

    // Call this method to start the movement
    public void StartMoving()
    {
        isMoving = true;
    }
}
