using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void OpenMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    // Update is called once per frame
    public void OpenGame()
    {
        SceneManager.LoadScene("Start");
    }
    public void OpenAboutTheGame()
    {
        SceneManager.LoadScene("About the game");
    }
    }