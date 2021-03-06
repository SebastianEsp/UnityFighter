﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    enum Stance
    {
        up,
        down,
        middle,
    }

    enum State
    {
        isAirborne,
        isAttacking,
        isParrying,
        isIdle,
    }

    public Animator animator;

    State state;
    Stance stance;
    
	// Use this for initialization
	void Start () 
    {

	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetButtonDown("Jump"))
        {
            state = State.isAttacking;
            animator.Play("ninja_Stab");

            Debug.Log(state);
        }

        if (Input.GetButtonDown("Horizontal"))
        {
            animator.Play("ninja_Walk");
        }

        if (Input.GetButtonUp("Horizontal"))
        {
            animator.Play("ninja_Idle");
        }

        if (Input.GetButtonDown("Vertical"))
        {
            animator.Play("ninja_Slash");
        }
	}
}
