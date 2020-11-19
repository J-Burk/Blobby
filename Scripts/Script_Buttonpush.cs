using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Buttonpush : MonoBehaviour
{
    public bool buttonpushed; // isButtonPushed
    public bool isButtonDefault;
    public bool isButtonInRotation;
    public GameObject Schalter;

    private void Start() {
        buttonpushed = false;
        isButtonDefault = false;
        isButtonInRotation = false;
    }
    private void Update() {
        // Enum (Stats)
        if(buttonpushed && isButtonInRotation) {
            Schalter.transform.Rotate(0, 0, 80);
            isButtonInRotation = false;
        }
        if(!isButtonInRotation) {
            Schalter.transform.Rotate(0, 0, 0);
        }
        if(isButtonDefault) {
            Schalter.transform.Rotate(0, 0, -80);
            isButtonDefault = false;
        }

    }

    public void OnTriggerStay(Collider box)
    {
        if (box.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E) && !buttonpushed)
            {
                buttonpushed = true;
                isButtonInRotation = true;
            }
        }
    }
}
