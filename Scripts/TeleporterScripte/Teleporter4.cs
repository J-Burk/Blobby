using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter4 : MonoBehaviour
{
    public GameObject raetsel;
    public GameObject Levelwechseler;
    GameObject Counter;

    void Start()
    {
        Levelwechseler.SetActive(false);
        Counter = GameObject.FindWithTag("Counter");
    }


    void Update()
    {
        if(raetsel.GetComponent<Script_Pressureplate>().raetsel && Counter.GetComponent<DestroidMagic>().destroidMagic == 11) {
            Levelwechseler.SetActive(true);
        }
    }
}
