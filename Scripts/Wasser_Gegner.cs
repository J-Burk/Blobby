using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wasser_Gegner : MonoBehaviour
{
    public int Leben;
    public int Schaden;
    public float Count;

    GameObject WasserGegner;

    public Script_HUD Script_HUD;
    public GameObject spieler;


    void Start()
    {
        Leben = 50;
        spieler = GameObject.FindWithTag("Player");
    }


    void Update()
    {
        if (Leben <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (Count <= 5 && WasserGegner && spieler)
        {
            Count += Time.deltaTime;
        }
        if (Count >= 5)
        {
            Count = 0;
            BerechneWasserSchaden(Schaden);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Count = 0;
    }

    void BerechneWasserSchaden(int Schaden)
    {
        Leben -= Schaden;
    }

    void BerechnePlayerSchaden()
    {
        spieler.GetComponent<Script_HUD>().aktLeben --;
    }
}
