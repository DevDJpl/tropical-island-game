using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausemenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject ExitMenu;
    public bool isPaused;
    public bool Exit;
    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
        ExitMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused)
            {
                ResumeGame();
            }
            else { PauseGame();
            }
        }
    }
    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        isPaused = true;
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        isPaused = false;
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("menu");
    }

    public void Exittrue()
    {
        ExitMenu.SetActive(true);
    }
    public void Exitfalse()
    {
        ExitMenu.SetActive(false);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
