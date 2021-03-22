﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animcontroller_halfsmile : MonoBehaviour
{
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("j"))
        {
            anim.CrossFade("half-smile-J", 0.25f);
        }

    }
}
