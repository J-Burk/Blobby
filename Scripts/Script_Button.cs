using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Button : MonoBehaviour
{
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public GameObject button5;
    public GameObject button6;
    public GameObject partikel;
    public List<GameObject> Buttons;

    private void Start()
    {
        partikel.SetActive(false);
        // button3Script = button3.GetComponent<Script_Buttonpush>();
    }

    private void Update()
    {
        if(button2.GetComponent<Script_Buttonpush>().buttonpushed == true && button1.GetComponent<Script_Buttonpush>().buttonpushed == false) {
            foreach(GameObject Button in Buttons) {
                if(Button.GetComponent<Script_Buttonpush>().buttonpushed) {
                    Button.GetComponent<Script_Buttonpush>().isButtonDefault = true;
                    Button.GetComponent<Script_Buttonpush>().buttonpushed = false;
                }
            }
        } else if(button3.GetComponent<Script_Buttonpush>().buttonpushed == true && button2.GetComponent<Script_Buttonpush>().buttonpushed == false) {
            foreach(GameObject Button in Buttons) {
                if(Button.GetComponent<Script_Buttonpush>().buttonpushed) {
                    Button.GetComponent<Script_Buttonpush>().isButtonDefault = true;
                    Button.GetComponent<Script_Buttonpush>().buttonpushed = false;
                }
            }
        } else if(button4.GetComponent<Script_Buttonpush>().buttonpushed == true && button3.GetComponent<Script_Buttonpush>().buttonpushed == false) {
            foreach(GameObject Button in Buttons) {
                if(Button.GetComponent<Script_Buttonpush>().buttonpushed) {
                    Button.GetComponent<Script_Buttonpush>().isButtonDefault = true;
                    Button.GetComponent<Script_Buttonpush>().buttonpushed = false;
                }
            }
        } else if(button5.GetComponent<Script_Buttonpush>().buttonpushed == true && button4.GetComponent<Script_Buttonpush>().buttonpushed == false) {
            foreach(GameObject Button in Buttons) {
                if(Button.GetComponent<Script_Buttonpush>().buttonpushed) {
                    Button.GetComponent<Script_Buttonpush>().isButtonDefault = true;
                    Button.GetComponent<Script_Buttonpush>().buttonpushed = false;
                }
            }
        } else if (button6.GetComponent<Script_Buttonpush>().buttonpushed == true && button5.GetComponent<Script_Buttonpush>().buttonpushed == false)
        {
            foreach(GameObject Button in Buttons) {
                if(Button.GetComponent<Script_Buttonpush>().buttonpushed) {
                    Button.GetComponent<Script_Buttonpush>().isButtonDefault = true;
                    Button.GetComponent<Script_Buttonpush>().buttonpushed = false;
                }
            }
        }

        if (button1.GetComponent<Script_Buttonpush>().buttonpushed == true && button2.GetComponent<Script_Buttonpush>().buttonpushed == true && button3.GetComponent<Script_Buttonpush>().buttonpushed == true && button4.GetComponent<Script_Buttonpush>().buttonpushed == true && button5.GetComponent<Script_Buttonpush>().buttonpushed == true && button6.GetComponent<Script_Buttonpush>().buttonpushed == true)
        {
            partikel.SetActive(true);
        }
    }
}
