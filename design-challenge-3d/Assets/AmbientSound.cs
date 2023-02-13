using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbientSound : MonoBehaviour
{
    public AudioClip sound;  // the audio clip to play
    public float maxDistance = 10f;  // the maximum distance at which the sound can be heard
    public Transform character;  // the character whose distance from the object determines the sound volume

    void Update()
    {
        // calculate the distance between the character and the object
        float distance = Vector3.Distance(transform.position, character.position);

        // calculate the volume of the sound based on the distance
        float volume = Mathf.Clamp01(1f - distance / maxDistance);

        // play the sound with the calculated volume
       AudioManager.instance.PlaySound(sound, volume);
    }
}