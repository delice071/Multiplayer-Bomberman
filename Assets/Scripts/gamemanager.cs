using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{
    AudioSource audioSO;
    public AudioClip click;
    public GameObject[] players;
    public GameObject winnerOne, winnerTwo, winnerThree, winnerFour, panel;


    private void Start()
    {
        audioSO = GetComponent<AudioSource>();
        Time.timeScale = 1.0f;
        winnerOne.SetActive(false);
        winnerTwo.SetActive(false);
        winnerThree.SetActive(false);
        winnerFour.SetActive(false);
        panel.SetActive(false);
    }
    public void CheckWinState()
    {
        int aliveCount = 0;

        foreach(GameObject player in players)
        {
            if (player.activeSelf)
            {
                aliveCount++;
            }
        }

        if(aliveCount <=1)
        {
            Time.timeScale = 0f;
            panel.SetActive(true);
            if (players[0].activeSelf)
            {
                winnerOne.SetActive(true);
            }
            if (players[1].activeSelf)
            {
                winnerTwo.SetActive(true);
            }
            if (players[2].activeSelf)
            {
                winnerThree.SetActive(true);
            }
            if (players[3].activeSelf)
            {
                winnerFour.SetActive(true);
            }
            
        }
    }

    


    public void tryagain()
    {
        audioSO.PlayOneShot(click);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void anamenu()
    {
        audioSO.PlayOneShot(click);
        SceneManager.LoadScene(0);
    }
}
