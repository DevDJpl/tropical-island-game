using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public GameObject walecNie;
    public GameObject walecTak;
    public GameObject placbudowy;
    float CurrentBalance;
    float BaseStoreCost;
    float BaseStoreProfit;
    float walecTimer = 0;
    bool StartWalecTimer;
    bool StartTimer;

    public Text CurrentBalanceText;

    float StoreTimer = 4;
    float CurrentTimer = 0;

    // Start is called before the first frame update
    void Start()
    {
        walecTak.SetActive(false);
        placbudowy.SetActive(false);
        CurrentBalance = 1200;
        BaseStoreCost = 1000;
        BaseStoreProfit = 10;
        CurrentBalanceText.text = CurrentBalance.ToString();
        StartWalecTimer = false;
        StartTimer = false;
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
                    StartWalecTimer = true;
                    walecNie.SetActive(false);
                    placbudowy.SetActive(true);
                    CurrentBalance = CurrentBalance - BaseStoreCost;
                    CurrentBalanceText.text = CurrentBalance.ToString();
                }
            }
        }
        if (StartTimer)
        {
            CurrentTimer += Time.deltaTime;
            if(CurrentTimer > StoreTimer)
            {
                //StartTimer = false;
                CurrentTimer = 0f;
                CurrentBalance += BaseStoreProfit;
                CurrentBalanceText.text = CurrentBalance.ToString();
            }
        }
        if (StartWalecTimer)
        {
            walecTimer += Time.deltaTime;
            if (walecTimer > 4)
            {
                StartWalecTimer = false;
                placbudowy.SetActive(false);
                walecTak.SetActive(true);
                StartTimer = true;
            }
        }
    }
}