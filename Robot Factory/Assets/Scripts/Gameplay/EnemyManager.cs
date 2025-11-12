using UnityEngine;
using UnityEngine.AI;
<<<<<<< HEAD
using System.Collections;
using System.Collections.Generic;
=======
>>>>>>> Angelo_Implementations

public class EnemyManager : MonoBehaviour
{
    [SerializeField] GameObject redEnemy;
    [SerializeField] GameObject blueEnemy;
    [SerializeField] GameObject greenEnemy;
    [SerializeField] GameObject yellowEnemy;
    [SerializeField] float spawnTimer;
    public float timer;
    public float spawnSpeedInterval;
    public GameObject Player;
    private GameObject[] Spawners;
    public int minSpawn;
    public int maxSpawn;
    private int spawnNum = 0;
<<<<<<< HEAD
   public Queue<GameObject> redEnemies = new Queue<GameObject>();
    public Queue<GameObject> blueEnemies = new Queue<GameObject>();
    public Queue<GameObject> greenEnemies = new Queue<GameObject>();
    public Queue<GameObject> yellowEnemies = new Queue<GameObject>();
    public static EnemyManager Instance;

    public void Awake()
    {
        Instance = this;
    }
=======

>>>>>>> Angelo_Implementations

    private void Start()
    {
        Spawners = GameObject.FindGameObjectsWithTag("spawners");
        timer = spawnTimer;
    }
    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            SpawnEnemies();
            timer = spawnTimer;
<<<<<<< HEAD
            if (spawnTimer >= 0.5f)
            {
                spawnTimer -= spawnSpeedInterval;
            }
=======
            spawnTimer -= spawnSpeedInterval;
>>>>>>> Angelo_Implementations
        }
      

    }

    void SpawnEnemies()
    {
        if (Spawners.Length > 0)
        {
            spawnNum = Random.Range(minSpawn, maxSpawn);
        }
        for (int i = 0; i <= spawnNum; i++)
        {
            int randSpawner = Random.Range(0, Spawners.Length);

            GameObject spawnLocation = Spawners[randSpawner];
            int enemyType = Random.Range(0, 4);
            if (enemyType == 0)
            {
                GameObject spawnedEnemy = Instantiate(redEnemy, spawnLocation.transform.position, Quaternion.identity);
                NavMeshAgent agent = spawnedEnemy.GetComponent<NavMeshAgent>();
                agent.destination = Player.transform.position;
<<<<<<< HEAD
                redEnemies.Enqueue(spawnedEnemy);
=======
>>>>>>> Angelo_Implementations
            }
            else if (enemyType == 1)
            {
               GameObject spawnedEnemy = Instantiate(blueEnemy, spawnLocation.transform.position, Quaternion.identity);
                NavMeshAgent agent = spawnedEnemy.GetComponent<NavMeshAgent>();
                agent.destination = Player.transform.position;
<<<<<<< HEAD
                blueEnemies.Enqueue(spawnedEnemy);
=======
>>>>>>> Angelo_Implementations
            }
            else if (enemyType == 2)
            {
                GameObject spawnedEnemy = Instantiate(greenEnemy, spawnLocation.transform.position, Quaternion.identity);
                NavMeshAgent agent = spawnedEnemy.GetComponent<NavMeshAgent>();
                agent.destination = Player.transform.position;
<<<<<<< HEAD
                greenEnemies.Enqueue(spawnedEnemy);
=======
>>>>>>> Angelo_Implementations
            }
            else if (enemyType == 3) {
                GameObject spawnedEnemy = Instantiate(yellowEnemy, spawnLocation.transform.position, Quaternion.identity);
                NavMeshAgent agent = spawnedEnemy.GetComponent<NavMeshAgent>();
                agent.destination = Player.transform.position;
<<<<<<< HEAD
                yellowEnemies.Enqueue(spawnedEnemy);
=======
>>>>>>> Angelo_Implementations
            }

        }
    }

<<<<<<< HEAD
    public void DestroyOldestRed()
    {
        if (redEnemies.Count > 0)
        {
            GameObject oldestRed = redEnemies.Dequeue();
            if (oldestRed != null)
            {
                Destroy(oldestRed);
                Debug.Log("Destroyed oldest red");
            }
        }
    }

    public void DestroyOldestBlue()
    {
        if (blueEnemies.Count > 0)
        {
            GameObject oldestBlue = blueEnemies.Dequeue();
            if (oldestBlue != null)
            {
                Destroy(oldestBlue);
                Debug.Log("Destroyed oldest blue");
            }
        }
    }

    public void DestroyOldestGreen()
    {
        if (greenEnemies.Count > 0)
        {
            GameObject oldestGreen = greenEnemies.Dequeue();
            if (oldestGreen != null)
            {
                Destroy(oldestGreen);
                Debug.Log("Destroyed oldest green");
            }
        }
    }

    public void DestroyOldestYellow()
    {
        if (yellowEnemies.Count > 0)
        {
            GameObject oldestYellow = yellowEnemies.Dequeue();
            if (oldestYellow != null)
            {
                Destroy(oldestYellow);
                Debug.Log("Destroyed oldest yellow");
            }
        }
    }

=======
  
>>>>>>> Angelo_Implementations
}
