using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class selectisland : MonoBehaviour
{
    public GameObject island1;
    public GameObject island2;
    public bool isChangedTo2 = false;

    void Start()
    {
        island1.SetActive(true);
        island2.SetActive(false);
    }
    public void Arrow()
    {
        if(isChangedTo2 == false)
        {
            island1.SetActive(false);
            island2.SetActive(true);
            isChangedTo2 = true;
        } else{
            island1.SetActive(true);
            island2.SetActive(false);
            isChangedTo2 = false;
        }
    }
    public void ChoseIsland()
    {
        if(isChangedTo2 == false){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        } else{
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +2);
        }  
    }

}
