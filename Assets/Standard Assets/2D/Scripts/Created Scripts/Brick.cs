using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour
{
   public int health = 2;
   public int points = 1;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        health -= 1; // health -= 1 is the same as saying health = health - 1
        if(health == 0){
            gameObject.SetActive(false);
            FindObjectOfType<Ball>().YouBrokeABrick();
        }

       
    }
}

