﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReapitingBG : MonoBehaviour {

    public float speed;
    public float endX;
    public float startX;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        if(transform.position.x <= endX){
            Vector2 pos = new Vector2(startX, transform.position.y);
            transform.position = pos;
        }
	}
}
