using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter1 : MonoBehaviour
{
    public GameObject raetsel1;
    public GameObject raetsel2;
    public GameObject Levelwechseler;

    void Start()
    {
        Levelwechseler.SetActive(false);
    }


    void Update()
    {
        if(raetsel1.GetComponent<Script_Pressureplate>().raetsel && raetsel2.GetComponent<Script_Pressureplate>().raetsel) {
            Levelwechseler.SetActive(true);
        }
    }
}
