﻿/**************************************************************************************************************
 * Author : Rickman Roedavan
 * Version: 2.12
 * Desc   : Script untuk menunjukkan dasar-dasar pergerakan dalam Unity yang terdiri dari Position, Rotation, & Scale.
 **************************************************************************************************************/

 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThisTransformScale : MonoBehaviour {

    public Vector3 IncrementScale;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.localScale += IncrementScale;
    }
}
