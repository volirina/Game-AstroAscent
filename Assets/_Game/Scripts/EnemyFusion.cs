using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFusion : Death
{
    // INHERITANCE: This class inherits from the parent class "Death".
    // POLYMORPHISM: This class overrides the LateUpdate method.
    // ENCAPSULATION: Getters and setters are used to access and modify the "scaleSpeed" variable.

    private float _scaleSpeed = 0.01f;

    public float scaleSpeed
    {
        get { return _scaleSpeed; }
        set { _scaleSpeed = value; }
    }

    private float timeSinceLastScale = 0.0f;
    private float timeToScale = 1.0f;

    protected override void LateUpdate()
    {
        // Call the MoveTowardsPlayer method from the parent class
        MoveTowardsPlayer();

        // Add additional behavior for the EnemyFusion class
        float deltaTime = 0.01f * Time.deltaTime;
        transform.localScale += new Vector3(scaleSpeed * deltaTime, scaleSpeed * deltaTime, scaleSpeed * deltaTime);
        speed += 1.1f * deltaTime;
    }
}
