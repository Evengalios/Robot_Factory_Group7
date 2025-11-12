using UnityEngine;

public class BarcodeAttack : MonoBehaviour
{
    private string currentBarcode = "";
    private Renderer objectRenderer;
<<<<<<< HEAD
    public GameObject enemyManager;
=======
    private GameObject[] atkEnemies;
>>>>>>> Angelo_Implementations



    void Update()
    {
        // Check for any key press
        if (Input.anyKeyDown)
        {

            // Get the last character pressed
            string inputChar = Input.inputString;

            // If it's not empty and not the Enter key
            if (!string.IsNullOrEmpty(inputChar) && inputChar != "\n" && inputChar != "\r")
            {
                currentBarcode += inputChar;
                Debug.Log(inputChar);
            }

        }
        // commands to destroy enemies on enter
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (currentBarcode.Contains("red"))
            {
<<<<<<< HEAD
                if (EnemyManager.Instance != null)
                {
                    EnemyManager.Instance.DestroyOldestRed();
=======
                atkEnemies = GameObject.FindGameObjectsWithTag("redEnemy");
                foreach (GameObject obj in atkEnemies)
                {
                    Destroy(obj);
>>>>>>> Angelo_Implementations
                }
            }
            else if (currentBarcode.Contains("blue"))
            {
<<<<<<< HEAD
                if (EnemyManager.Instance != null)
                {
                    EnemyManager.Instance.DestroyOldestBlue();
=======
                atkEnemies = GameObject.FindGameObjectsWithTag("blueEnemy");
                foreach (GameObject obj in atkEnemies)
                {
                    Destroy(obj);
>>>>>>> Angelo_Implementations
                }
            }
            else if (currentBarcode.Contains("green"))
            {
<<<<<<< HEAD
                if (EnemyManager.Instance != null)
                {
                    EnemyManager.Instance.DestroyOldestGreen();
=======
                atkEnemies = GameObject.FindGameObjectsWithTag("greenEnemy");
                foreach (GameObject obj in atkEnemies)
                {
                    Destroy(obj);
>>>>>>> Angelo_Implementations
                }
            }
            else if (currentBarcode.Contains("yellow"))
            {
<<<<<<< HEAD
                if (EnemyManager.Instance != null)
                {
                    EnemyManager.Instance.DestroyOldestYellow();
=======
                atkEnemies = GameObject.FindGameObjectsWithTag("yellowEnemy");
                foreach (GameObject obj in atkEnemies)
                {
                    Destroy(obj);
>>>>>>> Angelo_Implementations
                }
            }
            else
            {
<<<<<<< HEAD
                Debug.Log("no enemies of type");
            }
            


                Debug.Log("Scanned Barcode " + currentBarcode);
=======
                Debug.Log("Not Valid");
            }

            Debug.Log("Scanned Barcode " + currentBarcode);
>>>>>>> Angelo_Implementations
            currentBarcode = "";


        }



    }
}