using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI[] menuOptions;
    [SerializeField] private Color selectedColor = Color.white;
    [SerializeField] private Color deselectedColor = Color.gray;

    private int currentSelection = 0;
    private string[] originalTexts;
    private Camera uiCamera;

    void Start()
    {
        //Stores original text values
        originalTexts = new string[menuOptions.Length];
        for (int i = 0; i < menuOptions.Length; i++)
        {
            originalTexts[i] = menuOptions[i].text.TrimStart('>', ' ').Trim();
        }

        //Gets the UI camera from the canvas
        Canvas canvas = menuOptions[0].canvas;
        uiCamera = canvas.worldCamera;
     

        UpdateMenuDisplay();
    }

    void Update()
    {
        HandleInput();
    }

    void HandleInput()
    {
        //Keyboard nav
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            currentSelection--;
            if (currentSelection < 0)
                currentSelection = menuOptions.Length - 1;
            UpdateMenuDisplay();
        }

        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            currentSelection++;
            if (currentSelection >= menuOptions.Length)
                currentSelection = 0;
            UpdateMenuDisplay();
        }

        //Mouse nav
        HandleMouseSelection();

        //Selection
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetMouseButtonDown(0))
        {
            SelectOption();
        }
    }

    void HandleMouseSelection()
    {
        for (int i = 0; i < menuOptions.Length; i++)
        {
            RectTransform rectTransform = menuOptions[i].GetComponent<RectTransform>();

            if (RectTransformUtility.RectangleContainsScreenPoint(rectTransform, Input.mousePosition, uiCamera))
            {
                if (currentSelection != i)
                {
                    currentSelection = i;
                    UpdateMenuDisplay();
                }
                break; 
            }
        }
    }

    void UpdateMenuDisplay()
    {
        for (int i = 0; i < menuOptions.Length; i++)
        {
            if (i == currentSelection)
            {
                menuOptions[i].text = "> " + originalTexts[i];
                menuOptions[i].color = selectedColor;
            }
            else
            {
                menuOptions[i].text = "  " + originalTexts[i];
                menuOptions[i].color = deselectedColor;
            }
        }
    }

    void SelectOption()
    {
        switch (currentSelection)
        {
            case 0:
                Debug.Log("New Game selected");
                SceneManager.LoadScene("IntroSequence");
                break;
            case 1:
                Debug.Log("Settings selected");
                // OpenSettings();
                break;
            case 2:
                Debug.Log("Quit selected");
#if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
#else
                Application.Quit();
#endif
                break;
        }
    }
}