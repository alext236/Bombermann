﻿using UnityEngine;
using System.Collections;

public class Bomb : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //Used as animation event
    void DestroyBomb() {
        Destroy(gameObject);
    }
}
