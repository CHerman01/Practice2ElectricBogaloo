using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public PlayerHealth playerHealth;       // Reference to the player's heatlh.
    public GameObject enemy;                // The enemy prefab to be spawned.
    public GameObject enemy2;               // The speedy enemy
    public float spawnTime = 3f;            // How long between each spawn.
    public Transform[] spawnPoints;         // An array of the spawn points this enemy can spawn from.
    public GameObject[] Objectives;

    public static int score;

    void Start()
    {
        // Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }

    private void Update()
    {
    if(Objectives.Length == 3)
        {
            spawnTime -= .25f;
        }else if(Objectives.Length == 2)
        {
            spawnTime -= .25f;
        }else if (Objectives.Length == 1)
        {
            spawnTime -= .15f;
        }


    }


    void Spawn()
    {
        // If the player has no health left...
        if (playerHealth.currentHealth <= 0f)
        {
            // ... exit the function.
            return;
        }

        // Find a random index between zero and one less than the number of spawn points.
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);

        // Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
        Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
            
            if(Objectives.Length == 5)
        {
        Instantiate(enemy2, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
        }
    }
}