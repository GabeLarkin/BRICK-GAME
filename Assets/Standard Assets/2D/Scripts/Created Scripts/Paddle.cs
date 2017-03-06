using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

    Rigidbody2D rigidBody;
    public float speed = 5;

    void Start () {
         rigidBody = GetComponent<Rigidbody2D>();

    }
	
	// Update is called once per frame
	void Update () {
        float x = Input.GetAxisRaw("Horizontal");
        x = x * speed;
        rigidBody.velocity = new Vector2(x, 0);
    }
}