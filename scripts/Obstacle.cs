using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {

    public int damage = 1;
    public float speed;
    public GameObject effect;
    public GameObject explosion;



    // Update is called once per frame
    void Update () {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
	}

    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.CompareTag("Player")){
            Instantiate(explosion, transform.position, Quaternion.identity);
            Instantiate(effect, transform.position, Quaternion.identity);
            collision.GetComponent<Player>().health -= damage;
            Destroy(gameObject);
        }
    }
}
