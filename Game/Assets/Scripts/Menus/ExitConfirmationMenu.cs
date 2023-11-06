using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitConfirmationMenu: MonoBehaviour
{
    public void GoToPauseMenu(){
        //SceneManager.LoadScene("PauseMenu");
    }
    public void QuitGame(){
        Application.Quit();
    }
}