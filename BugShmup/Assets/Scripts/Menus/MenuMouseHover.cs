﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMouseHover : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        GetComponent<Renderer>().material.color = Color.black;
	}

    void OnMouseEnter()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }

    void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = Color.black;
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
