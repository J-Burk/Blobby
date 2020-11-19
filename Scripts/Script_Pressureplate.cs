using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Pressureplate:MonoBehaviour {

    public GameObject eigenesObjekt;
    public GameObject Kugel;
    public GameObject KugelPlatz;
    public bool raetsel = false;
    public bool fooo = false;
    public void OnTriggerStay(Collider box) {
        if(box.gameObject.tag == "Interactable") {
            Debug.Log("Kiste is druff");
            raetsel = true;
            Kugel.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        }
    }
    public void OnTriggerEnter(Collider box) {
        if(box.gameObject.tag == "Interactable" && !fooo) {
            eigenesObjekt.transform.position = eigenesObjekt.transform.position + new Vector3(0, -0.1f, 0);
            Kugel.transform.position = KugelPlatz.transform.position;
            fooo = true;
        }
    }
}
