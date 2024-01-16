using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public GameObject walecNie;
    public GameObject walecNie2;
    public GameObject walecNieUmbrella;
    public GameObject walecTak;
    public GameObject walecTakRestaurant;
    public GameObject walecHouseDoubleLv2;
    public GameObject placbudowy;
    public GameObject domek;
    public GameObject domekPrzycisk;
    public GameObject domekLv2;
    public GameObject umbrellas;
    public GameObject upgradeDomek;
    public GameObject OknoRestaurant1;
    public GameObject BuyRestaurantLv1;
    public GameObject OknoRestaurant2;
    public GameObject upgradeDoubleHouse;
    public GameObject OknoDomekLv1;
    public GameObject BuyDomekLv1;
    public GameObject OknoDomekLv2;
    public GameObject OknoParasoleLv1;
    public GameObject BuyParasoleLv1;
    float CurrentBalance;
    float BaseStoreCost;
    float BaseStoreProfit;
    float walecTimer = 0;
    bool StartWalecTimer;
    bool StartTimer;
    float UpgradeDoubleHouseCost;
    float doubleHouse2Timer = 0;
    bool StartDoubleHouse2Timer;
    //Domek
    float DomekProfit;
    float domekTimer = 0;
    bool StartDomekTimer;
    bool DomekTimer;
    float CurrentDomekTimer = 0;
    float UpgradeDomekCost;
    float domek2Timer = 0;
    bool StartDomek2Timer;
    //Umbrellas
    float UmbrellaProfit;
    float umbrellaTimer = 0;
    bool StartUmbrellaTimer;
    bool UmbrellaTimer;
    float CurrentUmbrellaTimer = 0;

    public Text CurrentBalanceText;

    float StoreTimer = 2;
    float CurrentTimer = 0;

    // Start is called before the first frame update
    void Start()
    {
        walecTak.SetActive(false);
        placbudowy.SetActive(false);
        domek.SetActive(false);
        domekPrzycisk.SetActive(false);
        umbrellas.SetActive(false);
        walecHouseDoubleLv2.SetActive(false);
        domekLv2.SetActive(false);
        OknoRestaurant1.SetActive(false);
        OknoRestaurant2.SetActive(false);
        OknoDomekLv1.SetActive(false);
        OknoDomekLv2.SetActive(false);
        OknoParasoleLv1.SetActive(false);
        CurrentBalance = 1200;
        BaseStoreCost = 1000;
        BaseStoreProfit = 20;
        DomekProfit = 10;
        UmbrellaProfit = 30;
        UpgradeDoubleHouseCost = 1500;
        UpgradeDomekCost = 1200;
        CurrentBalanceText.text = CurrentBalance.ToString();
        StartWalecTimer = false;
        StartTimer = false;
        StartDomekTimer = false;
        DomekTimer = false;
        StartDoubleHouse2Timer = false;
        StartDomek2Timer = false;
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
                if (hit.collider.gameObject == BuyRestaurantLv1)
                {
                    if (BaseStoreCost > CurrentBalance)
                        return;
                    StartWalecTimer = true;
                    walecNie.SetActive(false);
                    placbudowy.transform.position = new Vector3(379, 83, 467);
                    placbudowy.SetActive(true);
                    CurrentBalance = CurrentBalance - BaseStoreCost;
                    CurrentBalanceText.text = CurrentBalance.ToString();
                }
                if (hit.collider.gameObject == BuyDomekLv1)
                {
                    if (BaseStoreCost > CurrentBalance)
                        return;
                    StartDomekTimer = true;
                    walecNie2.SetActive(false);
                    placbudowy.transform.position = new Vector3(360, 83, 532);
                    placbudowy.SetActive(true);
                    CurrentBalance = CurrentBalance - BaseStoreCost;
                    CurrentBalanceText.text = CurrentBalance.ToString();
                }
                if (hit.collider.gameObject == BuyParasoleLv1)
                {
                    if (BaseStoreCost > CurrentBalance)
                        return;
                    StartUmbrellaTimer = true;
                    walecNieUmbrella.SetActive(false);
                    placbudowy.transform.position = new Vector3(570, 72, 433);
                    placbudowy.SetActive(true);
                    CurrentBalance = CurrentBalance - BaseStoreCost;
                    CurrentBalanceText.text = CurrentBalance.ToString();
                }
                if (hit.collider.gameObject == upgradeDoubleHouse)
                {
                    if (UpgradeDoubleHouseCost > CurrentBalance)
                        return;
                    StartDoubleHouse2Timer = true;
                    upgradeDoubleHouse.SetActive(false);
                    placbudowy.transform.position = new Vector3(416, 83, 468);
                    placbudowy.SetActive(true);
                    CurrentBalance = CurrentBalance - UpgradeDoubleHouseCost;
                    CurrentBalanceText.text = CurrentBalance.ToString();
                }
                if (hit.collider.gameObject == walecTakRestaurant)
                {
                    if(BaseStoreProfit == 50)
                        return;
                    OknoRestaurant2.SetActive(true);
                } else {
                    OknoRestaurant2.SetActive(false);
                }
                if (hit.collider.gameObject == upgradeDomek)
                {
                    if (UpgradeDomekCost > CurrentBalance)
                        return;
                    StartDomek2Timer = true;
                    placbudowy.transform.position = new Vector3(409, 83, 528);
                    placbudowy.SetActive(true);
                    CurrentBalance = CurrentBalance - UpgradeDomekCost;
                    CurrentBalanceText.text = CurrentBalance.ToString();
                }
                if (hit.collider.gameObject == domekPrzycisk)
                {
                    if(DomekProfit == 30)
                        return;
                    OknoDomekLv2.SetActive(true);
                } else {
                    OknoDomekLv2.SetActive(false);
                }
                if (hit.collider.gameObject == walecNie)
                {
                    OknoRestaurant1.SetActive(true);
                } else {
                    OknoRestaurant1.SetActive(false);
                }
                if (hit.collider.gameObject == walecNie2)
                {
                    OknoDomekLv1.SetActive(true);
                } else {
                    OknoDomekLv1.SetActive(false);
                }
                if (hit.collider.gameObject == walecNieUmbrella)
                {
                    OknoParasoleLv1.SetActive(true);
                } else {
                    OknoParasoleLv1.SetActive(false);
                }
            }
        }
        if (StartTimer)
        {
            CurrentTimer += Time.deltaTime;
            if(CurrentTimer > StoreTimer)
            {
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
        if (StartDoubleHouse2Timer)
        {
            doubleHouse2Timer += Time.deltaTime;
            if (doubleHouse2Timer > 4)
            {
                StartDoubleHouse2Timer = false;
                placbudowy.SetActive(false);
                walecHouseDoubleLv2.SetActive(true);
                BaseStoreProfit = 50;
            }
        }//House
        if (DomekTimer)
        {
            CurrentDomekTimer += Time.deltaTime;
            if(CurrentDomekTimer > StoreTimer)
            {
                CurrentDomekTimer = 0f;
                CurrentBalance += DomekProfit;
                CurrentBalanceText.text = CurrentBalance.ToString();
            }
        }
        if (StartDomekTimer)
        {
            domekTimer += Time.deltaTime;
            if (domekTimer > 4)
            {
                StartDomekTimer = false;
                placbudowy.SetActive(false);
                domek.SetActive(true);
                domekPrzycisk.SetActive(true);
                DomekTimer = true;
            }
        }
        if (StartDomek2Timer)
        {
            domek2Timer += Time.deltaTime;
            if (domek2Timer > 4)
            {
                StartDomek2Timer = false;
                placbudowy.SetActive(false);
                domekLv2.SetActive(true);
                DomekProfit = 30;
            }
        }//Umbrella
        if (UmbrellaTimer)
        {
            CurrentUmbrellaTimer += Time.deltaTime;
            if(CurrentUmbrellaTimer > StoreTimer)
            {
                CurrentUmbrellaTimer = 0f;
                CurrentBalance += UmbrellaProfit;
                CurrentBalanceText.text = CurrentBalance.ToString();
            }
        }
        if (StartUmbrellaTimer)
        {
            umbrellaTimer += Time.deltaTime;
            if (umbrellaTimer > 4)
            {
                StartUmbrellaTimer = false;
                placbudowy.SetActive(false);
                umbrellas.SetActive(true);
                UmbrellaTimer = true;
            }
        }
    }
}