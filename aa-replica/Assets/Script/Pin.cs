using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    public bool isPinned = false;
    public float speed = 20f;
    public Rigidbody2D rb;
    
    void Update()
    {
        if(!isPinned)
            rb.MovePosition(rb.position + Vector2.up * (speed * Time.deltaTime));
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Rotator"))
        {
            isPinned = true;
            Score.pinCount++;
            transform.SetParent(col.transform);
        } 
        else if (col.CompareTag("Pin"))
        {
            // END GAME
            FindObjectOfType<GameManager>().endGame();
        }
    }
    
}
