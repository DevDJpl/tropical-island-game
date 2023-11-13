using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public GameObject walecNie;
    public GameObject walecTak;
    // Start is called before the first frame update
    void Start()
    {
        walecTak.SetActive(false);
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
                    walecTak.SetActive(true);
                    walecNie.SetActive(false);
                }
            }
        }
    }

}
