using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool gameHasEnded = false;

    public Animator animator;

    public Rotator rotator;
    public Spawner spawner;

    public void endGame()
    {
        if (gameHasEnded)
            return;

        animator.SetTrigger("EndGame");
        rotator.enabled = false;
        spawner.enabled = false;
        gameHasEnded = true;
        
    }
}
