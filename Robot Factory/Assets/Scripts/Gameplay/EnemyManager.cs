using UnityEngine;

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

    private void Update()
    {
        timer -= Time.deltaTime;

    }
}
