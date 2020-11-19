using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script_HUD : MonoBehaviour
{
    public GameObject player;

    int MaxLeben = 6;
    public int aktLeben;
    public GameObject Leben9;
    public GameObject Leben8;
    public GameObject Leben7;
    public GameObject Leben6;
    public GameObject Leben5;
    public GameObject Leben4;
    public GameObject Leben3;
    public GameObject Leben2;
    public GameObject Leben1;

    public int potanz;
    public Text anzpot;

    public GameObject feuermagieIcon;
    public GameObject wassermagieIcon;
    public GameObject erdmagieIcon;

    void Start() {
        potanz = 0;
        aktLeben = 6;
    }
    public void Hurt(int damage) 
    {
        aktLeben -= damage;
        Debug.Log("Health: " + aktLeben);
    }

    void Update() 
    {
        UpdateHUD();
    }

    void UpdateHUD() {
        if(aktLeben == 6) {
            Leben9.SetActive(true);
            Leben8.SetActive(false);
            Leben7.SetActive(false);
            Leben6.SetActive(true);
            Leben5.SetActive(false);
            Leben4.SetActive(false);
            Leben3.SetActive(true);
            Leben2.SetActive(false);
            Leben1.SetActive(false);
        }
        if(aktLeben == 5) {
            Leben9.SetActive(false);
            Leben8.SetActive(true);
            Leben7.SetActive(false);
            Leben6.SetActive(true);
            Leben5.SetActive(false);
            Leben4.SetActive(false);
            Leben3.SetActive(true);
            Leben2.SetActive(false);
            Leben1.SetActive(false);
        }
        if(aktLeben == 4) {
            Leben9.SetActive(false);
            Leben8.SetActive(false);
            Leben7.SetActive(true);
            Leben6.SetActive(true);
            Leben5.SetActive(false);
            Leben4.SetActive(false);
            Leben3.SetActive(true);
            Leben2.SetActive(false);
            Leben1.SetActive(false);
        }
        if(aktLeben == 3) {
            Leben9.SetActive(false);
            Leben8.SetActive(false);
            Leben7.SetActive(true);
            Leben6.SetActive(false);
            Leben5.SetActive(true);
            Leben4.SetActive(false);
            Leben3.SetActive(true);
            Leben2.SetActive(false);
            Leben1.SetActive(false);
        }
        if(aktLeben == 2) {
            Leben9.SetActive(false);
            Leben8.SetActive(false);
            Leben7.SetActive(true);
            Leben6.SetActive(false);
            Leben5.SetActive(false);
            Leben4.SetActive(true);
            Leben3.SetActive(true);
            Leben2.SetActive(false);
            Leben1.SetActive(false);
        }
        if(aktLeben == 1) {
            Leben9.SetActive(false);
            Leben8.SetActive(false);
            Leben7.SetActive(true);
            Leben6.SetActive(false);
            Leben5.SetActive(false);
            Leben4.SetActive(true);
            Leben3.SetActive(false);
            Leben2.SetActive(true);
            Leben1.SetActive(false);
        }

        anzpot.text = potanz.ToString();

        if(player.GetComponent<Script_Magie>().currentMagic == 1) {
            feuermagieIcon.SetActive(true);
            wassermagieIcon.SetActive(false);
            erdmagieIcon.SetActive(false);
        }
        if(player.GetComponent<Script_Magie>().currentMagic == 2) {
            feuermagieIcon.SetActive(false);
            wassermagieIcon.SetActive(true);
            erdmagieIcon.SetActive(false);
        }
        if(player.GetComponent<Script_Magie>().currentMagic == 3) {
            feuermagieIcon.SetActive(false);
            wassermagieIcon.SetActive(false);
            erdmagieIcon.SetActive(true);
        }
    }
}
