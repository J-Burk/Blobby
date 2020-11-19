using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Animation : MonoBehaviour
{
    Animator animator;
    bool walk;
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        walk = false;
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W)) {
            animator.SetBool("walk", true);
            Debug.Log("Eig is da was");
        }
        else if(Input.GetKeyUp(KeyCode.W)) {
            animator.SetBool("walk", false);
            Debug.Log("Eig is da nix");
        } else if(Input.GetKeyDown(KeyCode.S)) {
            animator.SetBool("backward", true);
            Debug.Log("Eig is da nix");
        } else if(Input.GetKeyUp(KeyCode.S)) {
            animator.SetBool("backward", false);
            Debug.Log("Eig is da nix");
        }

        // animator.SetBool("walk", walk);
    }
}
