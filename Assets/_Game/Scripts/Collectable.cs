using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.IncrementCollectibles();
            GameManager.Instance.playerSpeed += 0.2f;
            Destroy(gameObject);
        }
    }

}
