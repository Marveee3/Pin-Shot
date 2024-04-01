using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    [SerializeField]private float speed = 20f;
    private Rigidbody2D rb;
    private bool isPinned = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(!isPinned)rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime); //move the pin up
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Rotator") //checking for a collision with rotator
        {   
            transform.SetParent(col.transform);
            col.GetComponent<Rotator>().speed *= -1;
            Score.pinCount++;
            isPinned = true;
        }
        else if(col.tag == "Pin")//checking for a collision with another pin
        {
            //end game
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
