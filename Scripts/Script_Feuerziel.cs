using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Feuerziel : MonoBehaviour
{
    public int Leben;
    GameObject Counter;

    void Start()
    {
        Counter = GameObject.FindWithTag("Counter");
        Leben = 10;
    }

    void Update()
    {
        if (Leben <= 0)
        {
            Counter.GetComponent<DestroidMagic>().destroidMagic++;
            Destroy(gameObject);
        }
    }

    void BerechneFeuerSchaden(int schaden)
    {
        Leben -= schaden;
    }
}
