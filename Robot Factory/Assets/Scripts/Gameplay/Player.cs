using UnityEngine;

public class Player : MonoBehaviour
{
    public int health = 3;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "redEnemy" || collision.gameObject.tag == "blueEnemy" || collision.gameObject.tag == "greenEnemy" || collision.gameObject.tag == "yellowEnemy")
        {
            health -= 1;
            Destroy(collision.gameObject);
        }
    }

    private void Update()
    {
        if (health <= 0)
        {

        }
    }
}

