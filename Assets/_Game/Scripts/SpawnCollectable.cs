using UnityEngine;

public class SpawnCollectable : MonoBehaviour
{
    public GameObject prefabToInstantiate;
    public Collider spawnArea;
    public int numberOfPrefabs = 10;

    private void Start()
    {
        for (int i = 0; i < numberOfPrefabs; i++)
        {
            Vector3 randomPosition = GetRandomPositionInCollider(spawnArea);
            GameObject instantiatedPrefab = Instantiate(prefabToInstantiate, randomPosition, Quaternion.identity);
        }
    }

    private Vector3 GetRandomPositionInCollider(Collider collider)
    {
        Vector3 randomPoint = collider.bounds.center + new Vector3(
            Random.Range(-collider.bounds.extents.x, collider.bounds.extents.x),
            Random.Range(-collider.bounds.extents.y, collider.bounds.extents.y),
            Random.Range(-collider.bounds.extents.z, collider.bounds.extents.z)
        );

        return randomPoint;
    }

}
