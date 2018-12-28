/*Basic script to dictate all player actions, currently only changes animations based on inputs */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private Animator player_animator; //animator for player object

    // Start is called before the first frame update
    void Start()
    {
        player_animator = this.GetComponent<Animator>(); //ties player animator to animator variable
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2")) //on right cick
        {
            player_animator.SetBool("Walking", true); //transition from idle to walking
            Debug.Log("Right click");
        }
        if (Input.GetButtonDown("Fire1")) //on left cick
        {
            player_animator.SetBool("Walking", false); //transition from walking to idle
            Debug.Log("left click");
        }
        
    }
}
