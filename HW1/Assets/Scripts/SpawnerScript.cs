using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    // Public variable to hold the Prefab
    public GameObject prefabToSpawn;

    // Public variable to set the spawn location
    public Transform spawnPoint;

    // Update is called once per frame
    void Update()
    {
        // Check if the space key is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Spawn the prefab at the specified location and with no rotation
            Instantiate(prefabToSpawn, spawnPoint.position, Quaternion.identity);
        }
    }
}
