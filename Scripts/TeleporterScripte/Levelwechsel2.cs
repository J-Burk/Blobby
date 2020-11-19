using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levelwechsel2 : MonoBehaviour
{
    public GameObject naechsterEingang;
    public void OnTriggerEnter(Collider player) {
        if(player.gameObject.tag == "Player") {
            player.GetComponent<CharacterController>().enabled = false;
            player.transform.position = naechsterEingang.transform.position;
            player.GetComponent<CharacterController>().enabled = true;
        }
    }
}
