using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManger : MonoBehaviour {

    public int score;
    public Text scoreDisplay;
    public Text finalScore;
    public GameObject panel;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (panel.activeSelf)
        {
            finalScore.text = GetComponent<ScoreManger>().score.ToString();
        }
        scoreDisplay.text = score.ToString();
	}

    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.CompareTag("Obstacle") && !panel.activeSelf){
            score++;
        }
    }
}
