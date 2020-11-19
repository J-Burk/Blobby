using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endtrigger : MonoBehaviour {

    public GameObject raetsel1;
    public GameObject raetsel2;
    GameObject Counter;
    public GameObject Levelwechseler;

    void Start() {
        Levelwechseler.SetActive(false);
        Counter = GameObject.FindWithTag("Counter");
    }


    void Update() {
        if(raetsel1.GetComponent<Script_Pressureplate>().raetsel && raetsel2.GetComponent<Script_Pressureplate>().raetsel && Counter.GetComponent<DestroidMagic>().destroidMagic == 11) {
            Levelwechseler.SetActive(true);
        }
    }
}
