using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFusion : Death
{
    // INHERITANCE: This class inherits from the parent class "Death".

    public float scaleSpeed = 0.1f;

    private float timeSinceLastScale = 0.0f;
    private float timeToScale = 1.0f;

    protected override void LateUpdate()
    {
        base.LateUpdate();

        float deltaTime = 0.01f* Time.deltaTime;
        transform.localScale += new Vector3(scaleSpeed * deltaTime, scaleSpeed * deltaTime, scaleSpeed * deltaTime);
        speed += 2.0f * deltaTime;
    }
}
