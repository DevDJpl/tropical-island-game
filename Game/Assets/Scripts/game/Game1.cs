using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game1 : MonoBehaviour
{
    public GameObject walecNieNowe;
    public GameObject walecNieNamioty;
    public GameObject walecTower;
    public GameObject walecTakNowe;
    public GameObject walecTakRestaurantNowe;
    public GameObject walecHouseDoubleLv2Nowe;
    public GameObject placbudowyNowe;
    public GameObject Namioty;
    public GameObject domekPrzyciskNowe;
    public GameObject domekLv2Nowe;
    public GameObject umbrellasNowe;
    public GameObject upgradeDomekNowe;
    public GameObject OknoRestaurant1Nowe;
    public GameObject BuyRestaurantLv1Nowe;
    public GameObject OknoRestaurant2Nowe;
    public GameObject upgradeDoubleHouseNowe;
    public GameObject OknoNamiotyLv1;
    public GameObject BuyNamiotyLv1;
    public GameObject OknoDomekLv2Nowe;
    public GameObject OknoParasoleLv1Nowe;
    public GameObject BuyParasoleLv1Nowe;
    float CurrentBalance;
    float BaseStoreCost;
    float TowerCost;
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
        walecTakNowe.SetActive(false);
        placbudowyNowe.SetActive(false);
        Namioty.SetActive(false);
        domekPrzyciskNowe.SetActive(false);
        umbrellasNowe.SetActive(false);
        walecHouseDoubleLv2Nowe.SetActive(false);
        domekLv2Nowe.SetActive(false);
        OknoRestaurant1Nowe.SetActive(false);
        OknoRestaurant2Nowe.SetActive(false);
        OknoNamiotyLv1.SetActive(false);
        OknoDomekLv2Nowe.SetActive(false);
        OknoParasoleLv1Nowe.SetActive(false);
        walecTakRestaurantNowe.SetActive(false);
        CurrentBalance = 1200;
        BaseStoreCost = 1000;
        TowerCost = 1200;
        BaseStoreProfit = 20;
        DomekProfit = 30;
        UmbrellaProfit = 40;
        UpgradeDoubleHouseCost = 1000;
        UpgradeDomekCost = 1100;
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
                if (hit.collider.gameObject == BuyRestaurantLv1Nowe)
                {
                    if (BaseStoreCost > CurrentBalance)
                        return;
                    StartWalecTimer = true;
                    walecNieNowe.SetActive(false);
                    placbudowyNowe.transform.position = new Vector3(433, 78, 644);
                    placbudowyNowe.SetActive(true);
                    CurrentBalance = CurrentBalance - BaseStoreCost;
                    CurrentBalanceText.text = CurrentBalance.ToString();
                }
                if (hit.collider.gameObject == BuyNamiotyLv1)
                {
                    if (BaseStoreCost > CurrentBalance)
                        return;
                    StartDomekTimer = true;
                    walecNieNamioty.SetActive(false);
                    placbudowyNowe.transform.position = new Vector3(555, 79, 406);
                    placbudowyNowe.SetActive(true);
                    CurrentBalance = CurrentBalance - BaseStoreCost;
                    CurrentBalanceText.text = CurrentBalance.ToString();
                }
                if (hit.collider.gameObject == BuyParasoleLv1Nowe)
                {
                    if (TowerCost > CurrentBalance)
                        return;
                    StartUmbrellaTimer = true;
                    walecTower.SetActive(false);
                    placbudowyNowe.transform.position = new Vector3(465, 112, 497);
                    placbudowyNowe.SetActive(true);
                    CurrentBalance = CurrentBalance - TowerCost;
                    CurrentBalanceText.text = CurrentBalance.ToString();
                }
                if (hit.collider.gameObject == upgradeDoubleHouseNowe)
                {
                    if (UpgradeDoubleHouseCost > CurrentBalance)
                        return;
                    StartDoubleHouse2Timer = true;
                    upgradeDoubleHouseNowe.SetActive(false);
                    placbudowyNowe.transform.position = new Vector3(393, 78, 577);
                    placbudowyNowe.SetActive(true);
                    CurrentBalance = CurrentBalance - UpgradeDoubleHouseCost;
                    CurrentBalanceText.text = CurrentBalance.ToString();
                }
                if (hit.collider.gameObject == walecTakRestaurantNowe)
                {
                    if ( BaseStoreProfit == 20){
                        OknoRestaurant2Nowe.SetActive(true);
                    }
                } else {
                    OknoRestaurant2Nowe.SetActive(false);
                }
                if (hit.collider.gameObject == upgradeDomekNowe)
                {
                    if (UpgradeDomekCost > CurrentBalance)
                        return;
                    StartDomek2Timer = true;
                    placbudowyNowe.transform.position = new Vector3(531, 78, 379);
                    placbudowyNowe.SetActive(true);
                    CurrentBalance = CurrentBalance - UpgradeDomekCost;
                    CurrentBalanceText.text = CurrentBalance.ToString();
                }
                if (hit.collider.gameObject == domekPrzyciskNowe)
                {
                    if ( DomekProfit == 30 ){
                        OknoDomekLv2Nowe.SetActive(true);
                    }
                } else {
                    OknoDomekLv2Nowe.SetActive(false);
                }
                if (hit.collider.gameObject == walecNieNowe)
                {
                    OknoRestaurant1Nowe.SetActive(true);
                } else {
                    OknoRestaurant1Nowe.SetActive(false);
                }
                if (hit.collider.gameObject == walecNieNamioty)
                {
                    OknoNamiotyLv1.SetActive(true);
                } else {
                    OknoNamiotyLv1.SetActive(false);
                }
                if (hit.collider.gameObject == walecTower)
                {
                    OknoParasoleLv1Nowe.SetActive(true);
                } else {
                    OknoParasoleLv1Nowe.SetActive(false);
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
                placbudowyNowe.SetActive(false);
                walecTakNowe.SetActive(true);
                walecTakRestaurantNowe.SetActive(true);
                StartTimer = true;
            }
        }
        if (StartDoubleHouse2Timer)
        {
            doubleHouse2Timer += Time.deltaTime;
            if (doubleHouse2Timer > 4)
            {
                StartDoubleHouse2Timer = false;
                placbudowyNowe.SetActive(false);
                walecHouseDoubleLv2Nowe.SetActive(true);
                BaseStoreProfit = 40;
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
                placbudowyNowe.SetActive(false);
                Namioty.SetActive(true);
                domekPrzyciskNowe.SetActive(true);
                DomekTimer = true;
            }
        }
        if (StartDomek2Timer)
        {
            domek2Timer += Time.deltaTime;
            if (domek2Timer > 4)
            {
                StartDomek2Timer = false;
                placbudowyNowe.SetActive(false);
                domekLv2Nowe.SetActive(true);
                DomekProfit = 40;
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
                placbudowyNowe.SetActive(false);
                umbrellasNowe.SetActive(true);
                UmbrellaTimer = true;
            }
        }
    }
}