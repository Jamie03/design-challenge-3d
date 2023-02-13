using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;  // static instance of the AudioManager

    public AudioSource musicSource;  // audio source for playing music
    public AudioSource soundSource;  // audio source for playing sound effects

    void Awake()
    {
        // if there is no static instance of the AudioManager
        if (instance == null)
        {
            // set this object as the static instance
            instance = this;
        }
        // if there is already a static instance of the AudioManager
        else if (instance != this)
        {
            // destroy this object
            Destroy(gameObject);
        }

        // do not destroy this object when loading a new scene
        DontDestroyOnLoad(gameObject);
    }

    // method for playing music
    public void PlayMusic(AudioClip clip)
    {
        // set the audio clip of the music audio source
        musicSource.clip = clip;

        // play the music
        musicSource.Play();
    }

    // method for playing a sound effect
    public void PlaySound(AudioClip clip, float volume = 1f)
    {
        // set the audio clip and volume of the sound effect audio source
        soundSource.clip = clip;
        soundSource.volume = volume;

        // play the sound effect
        soundSource.PlayOneShot(clip);
    }
}