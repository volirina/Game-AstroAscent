using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    // INHERITANCE: This is the parent class for all enemy types in the game.
    protected float speed = 0.1f;
    public float rotationSpeed = 10.0f;

    // INHERITANCE
    protected Transform target;

    protected virtual void Start()
    {
        target = GameObject.FindWithTag("Player").transform;
    }

    // ABSTRACTION: This method abstracts away the details of rotating and moving the enemy towards the player.
    protected void MoveTowardsPlayer()
    {
        transform.position = Vector3.Lerp(transform.position, target.position, speed * Time.deltaTime);
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime, Space.World);
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime, Space.World);
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime, Space.World);
    }

    protected virtual void LateUpdate()
    {
        MoveTowardsPlayer();
    }
}
