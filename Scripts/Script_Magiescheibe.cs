using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Magiescheibe : MonoBehaviour
{
    public int Leben;

    void Start()
    {
        Leben = 10;
    }

    void Update()
    {
        if (Leben <= 0 )
        {
            Destroy(gameObject);
        }
    }

    void BerechneMagieSchaden(int schaden)
    {
        Leben -= schaden;
    }
}
