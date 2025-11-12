using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    
    public Sound[] music, sfx;
    public AudioSource musicSource, sfxSource;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        PlayMusic("FactoryAmbiance");
    }
    
    public void PlayMusic(string musicName)
    {
        Sound s = Array.Find(music, s => s.name == musicName);

        if (s == null)
        {
            Debug.LogWarning("Muisc " + musicName + " not found!");
        }
        else
        {
            musicSource.clip = s.clip;
            musicSource.Play();
        }
    }

    public void PlaySfx(string sfxName)
    {
        Sound s = Array.Find(sfx, s => s.name == sfxName);

        if (s == null)
        {
            Debug.LogWarning("Sfx " + sfxName + " not found!");
        }
        else
        {
            sfxSource.clip = s.clip;
            sfxSource.Play();
        }
    }
}
