using UnityEngine;
using UnityEngine.AI;

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
            spawnTimer -= spawnSpeedInterval;
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
            }
            else if (enemyType == 1)
            {
               GameObject spawnedEnemy = Instantiate(blueEnemy, spawnLocation.transform.position, Quaternion.identity);
                NavMeshAgent agent = spawnedEnemy.GetComponent<NavMeshAgent>();
                agent.destination = Player.transform.position;
            }
            else if (enemyType == 2)
            {
                GameObject spawnedEnemy = Instantiate(greenEnemy, spawnLocation.transform.position, Quaternion.identity);
                NavMeshAgent agent = spawnedEnemy.GetComponent<NavMeshAgent>();
                agent.destination = Player.transform.position;
            }
            else if (enemyType == 3) {
                GameObject spawnedEnemy = Instantiate(yellowEnemy, spawnLocation.transform.position, Quaternion.identity);
                NavMeshAgent agent = spawnedEnemy.GetComponent<NavMeshAgent>();
                agent.destination = Player.transform.position;
            }

        }
    }

  
}
