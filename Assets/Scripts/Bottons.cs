using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bottons : MonoBehaviour
{

    public AudioSource source;
    public AudioClip click;

    public GameObject mute;
    public GameObject noMute;

    void Start()
    {
       
            if (PlayerPrefs.GetString("Music") == ("no"))
            {
                AudioListener.volume = 0f;
            mute.SetActive(false);
            noMute.SetActive(true);
        }
            else
            {
            mute.SetActive(true);
            noMute.SetActive(false);
            AudioListener.volume = 1f;
               
            }
        
    }


    public void OnMouseUpAsBotton()
    {
        switch (gameObject.name)
        {
            case "Play":
                source.clip = click;
                source.Play();
                SceneManager.LoadScene("play");
            break;
        }
    }

    public void HowTo()
    {
        source.clip = click;
        source.Play();
        SceneManager.LoadScene("HowTo");
    }

    public void CloseHowTo()
    {
        source.clip = click;
        source.Play();
        SceneManager.LoadScene("menu");
    }

    public void Mute()
    {
        source.clip = click;
        source.Play();
        PlayerPrefs.SetString("Music", "no");
         mute.SetActive(false);
         noMute.SetActive(true);
        AudioListener.volume = 0f;

    }

    public void Nomute()
    {
        source.clip = click;
        source.Play();
        PlayerPrefs.SetString("Music", "yes");
        mute.SetActive(true);
        noMute.SetActive(false);
        AudioListener.volume = 1f;
    }

    public void NoAds()
    {
        source.clip = click;
        source.Play();
    }
}
