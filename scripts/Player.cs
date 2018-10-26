using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    private Vector2 targetPos;
    public float Yincrement;

    public float speed;
    public int maxHeight;
    public int minHeight;
    public int middleHeight;

    public int health;
    public Text healthDisplay;
    public GameObject effect;
    public GameObject pop;

    public GameObject gameOver;
    public AudioSource audioSource;

    private void Start()
    {
        targetPos = new Vector2(transform.position.x, middleHeight);
    }

    // Update is called once per frame
    void Update () {
        healthDisplay.text = health.ToString();

        if (health <= 0){
            gameOver.SetActive(true);
            
            Destroy(gameObject);
        }

        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
        if(Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight && (transform.position.y == maxHeight || transform.position.y == middleHeight || transform.position.y == minHeight)){
            Instantiate(pop, transform.position, Quaternion.identity);
            Instantiate(effect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
   
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight && (transform.position.y == maxHeight || transform.position.y == middleHeight || transform.position.y == minHeight)) {
            Instantiate(pop, transform.position, Quaternion.identity);
            Instantiate(effect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
            
        }

        if (Input.GetKeyDown(KeyCode.M))
            audioSource.mute = !audioSource.mute;
    }
}
