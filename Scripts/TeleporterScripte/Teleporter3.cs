using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter3 : MonoBehaviour
{
    public GameObject Levelwechesl3;
    GameObject Counter;
    void Start()
    {
        Counter = GameObject.FindWithTag("Counter");
    }


    void Update()
    {
        if(Counter.GetComponent<DestroidMagic>().destroidMagic == 8) {
            Levelwechesl3.SetActive(true);
        }            
        
    }
}
