using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public AudioClip click;
    AudioSource audioSo;


    public void Start()
    {
        audioSo = GetComponent<AudioSource>();
    }
    public void Playy()
    {
        audioSo.PlayOneShot(click);
        SceneManager.LoadScene(1);
    }

    public void exitt() 
    {
        audioSo.PlayOneShot(click);
        Application.Quit();
    }
    public void twoplayer()
    {
        audioSo.PlayOneShot(click);
        SceneManager.LoadScene(2);
    }
    public void threeplayer()
    {
        audioSo.PlayOneShot(click);
        SceneManager.LoadScene(3);
    }
    public void fourplayer()
    {
        audioSo.PlayOneShot(click);
        SceneManager.LoadScene(4);
    }

}
