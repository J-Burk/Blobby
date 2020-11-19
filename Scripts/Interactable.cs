using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public GameObject hebepunkt;
    public GameObject Map;
    public GameObject InteractableObject;
    Script_Pressureplate _Pressureplate;
    Vector3 aktpos;

    void Start()
    {
        if(InteractableObject.GetComponent<Script_Pressureplate>()) {
            _Pressureplate = InteractableObject.GetComponent<Script_Pressureplate>();
        }
    }


    void Update()
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            gameObject.transform.parent = null;
            gameObject.GetComponent<Rigidbody>().useGravity = true;
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        }
    }

    public void OnTriggerStay(Collider player)
    {
        if (player.gameObject.tag == "Player" && !_Pressureplate.fooo)
        {
            if (Input.GetKeyDown(KeyCode.E))                                    //GetButton("Interactable"))
            {
                gameObject.transform.parent = hebepunkt.transform;
                transform.position = transform.position + new Vector3(0, 0.5f, 0);
                gameObject.GetComponent<Rigidbody>().useGravity = false;
                GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            }
        }
    }
}
