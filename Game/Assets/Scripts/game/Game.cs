using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public GameObject walecNie;
    public GameObject walecTak;
    float CurrentBalance;
    float BaseStoreCost;

    public Text CurrentBalanceText;
    // Start is called before the first frame update
    void Start()
    {
        walecTak.SetActive(false);
        CurrentBalance = 8;
        BaseStoreCost = 1;
        CurrentBalanceText.text = CurrentBalance.ToString();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject == walecNie)
                {
                    if (BaseStoreCost > CurrentBalance)
                        return;
                    walecTak.SetActive(true);
                    walecNie.SetActive(false);
                    CurrentBalance = CurrentBalance - BaseStoreCost;
                    Debug.Log(CurrentBalance);
                    CurrentBalanceText.text = CurrentBalance.ToString();
                }
            }
        }
    }

}
