using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSoundEffects : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip playSFX, settingsSFX, quitSFX;

    public void PlayButton()
    {
        audioSource.clip = playSFX;
        audioSource.Play();
    }
    public void SettingsButton()
    {
        audioSource.clip = settingsSFX;
        audioSource.Play();
    }
    public void QuitButton()
    {
        audioSource.clip = quitSFX;
        audioSource.Play();
    }
}
