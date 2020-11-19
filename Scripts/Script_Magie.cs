using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Magie : MonoBehaviour
{
    public GameObject Schwert;
    public GameObject MagieImage;
    public GameObject AkktuelleMagie;
    public GameObject FireMagic;
    public GameObject WaterMagic;
    public GameObject EarthMagic;

    public int currentMagic; // 1 = Feuerzauber, 2 Wassermagie, 3 Erdzauber
    public bool activeMagic;

    public int schaden;
    public float distanz;
    public float maxDistanz;
    RaycastHit hit;

    void Start()
    {
        currentMagic = 1;
        activeMagic = false;
        maxDistanz = 10f;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (currentMagic < 3)
            {
                currentMagic++;
            }
            else
            {
                currentMagic = 1;
            }
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            if (currentMagic > 1)
            {
                currentMagic--;
            }
            else
            {
                currentMagic = 3;
            }

        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            activeMagic = true;
            aktiveMagie();
        }
        if (Input.GetKeyUp(KeyCode.G))
        {
            FireMagic.SetActive(false);
            WaterMagic.SetActive(false);
            EarthMagic.SetActive(false);
        }
    }

    void aktiveMagie()
    {
        if (currentMagic == 1)
        {
            FireMagic.SetActive(true);
            WaterMagic.SetActive(false);
            EarthMagic.SetActive(false);
            schaden = 10;
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
            {
                distanz = hit.distance;
                if (distanz < maxDistanz)
                {
                    Debug.Log("Hello ma dir");
                    hit.transform.SendMessage("BerechneFeuerSchaden", schaden);
                    hit.transform.SendMessage("BerechneMagieSchaden", schaden);
                }
            }
        }

        if (currentMagic == 2)
        {
            FireMagic.SetActive(false);
            WaterMagic.SetActive(true);
            EarthMagic.SetActive(false);
            schaden = 10;
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
            {
                distanz = hit.distance;
                if (distanz < maxDistanz)
                {
                    hit.transform.SendMessage("BerechneWasserSchaden", schaden);
                    hit.transform.SendMessage("BerechneMagieSchaden", schaden);
                }
            }
        }

        if (currentMagic == 3)
        {
            FireMagic.SetActive(false);
            WaterMagic.SetActive(false);
            EarthMagic.SetActive(true);
            schaden = 10;
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
            {
                distanz = hit.distance;
                if (distanz < maxDistanz)
                {
                    hit.transform.SendMessage("BerechneErdSchaden", schaden);
                    hit.transform.SendMessage("BerechneMagieSchaden", schaden);
                }
            }
        }
    }
}
