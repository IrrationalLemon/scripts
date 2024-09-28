using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrenght;
    public LogicScript logic;
    public bool BirdIsAlive = true;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && BirdIsAlive == true) {
            myRigidbody.velocity = Vector2.up * flapStrenght;
            transform.Rotate(new Vector3(0, 0, 30));
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        BirdIsAlive = false;
    }
}
