using UnityEngine;

public class BarcodeAttack : MonoBehaviour
{
    private string currentBarcode = "";
    private Renderer objectRenderer;
    private GameObject[] atkEnemies;



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
                atkEnemies = GameObject.FindGameObjectsWithTag("redEnemy");
                foreach (GameObject obj in atkEnemies)
                {
                    Destroy(obj);
                }
            }
            else if (currentBarcode.Contains("blue"))
            {
                atkEnemies = GameObject.FindGameObjectsWithTag("blueEnemy");
                foreach (GameObject obj in atkEnemies)
                {
                    Destroy(obj);
                }
            }
            else if (currentBarcode.Contains("green"))
            {
                atkEnemies = GameObject.FindGameObjectsWithTag("greenEnemy");
                foreach (GameObject obj in atkEnemies)
                {
                    Destroy(obj);
                }
            }
            else if (currentBarcode.Contains("yellow"))
            {
                atkEnemies = GameObject.FindGameObjectsWithTag("yellowEnemy");
                foreach (GameObject obj in atkEnemies)
                {
                    Destroy(obj);
                }
            }
            else
            {
                Debug.Log("Not Valid");
            }

            Debug.Log("Scanned Barcode " + currentBarcode);
            currentBarcode = "";


        }



    }
}