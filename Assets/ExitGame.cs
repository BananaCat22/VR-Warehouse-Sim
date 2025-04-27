using UnityEngine;
using UnityEngine.UI;

public class ExitGame : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Button exitButton;
    void Start()
    {
        exitButton.onClick.AddListener(exitGame);
    }

    // Update is called once per frame
    void exitGame()
    {
        Application.Quit();
    }
}
