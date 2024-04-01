using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{   
    private bool gameHasEnded = false;
    [SerializeField] Rotator rotator;
    [SerializeField] PinSpawner pinSpawner;
    private Animator anim;


    private void Start()
    {
        anim = GetComponent<Animator>();        
    }

    public void EndGame()
    {
        if(gameHasEnded)return;

        anim.SetTrigger("EndGame");
        rotator.enabled = false;
        pinSpawner.enabled = false;
        
        gameHasEnded = true;
    }

    void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
