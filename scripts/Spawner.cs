﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject[] obstaclePatterns;

    private float timeBtwSpawn;
    public float startTimeBtwSpawn;
    public float deceaseTime;
    public float minTime = 0.65f;

	
	// Update is called once per frame
	void Update () {
		if(timeBtwSpawn <= 0){
            int rand = Random.Range(0, obstaclePatterns.Length);
            Instantiate(obstaclePatterns[rand], transform.position, Quaternion.identity);
            timeBtwSpawn = startTimeBtwSpawn;
            if(startTimeBtwSpawn > minTime){
                startTimeBtwSpawn -= deceaseTime;
            }
        }
        else{
            timeBtwSpawn -= Time.deltaTime;
        }
	}
}
