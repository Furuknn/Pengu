using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundButton : MonoBehaviour
{
    public AudioSource menuMusic;
    public Button soundButton;
    public Sprite soundOnImage, soundOffImage;

    public void SoundButtonClick()
    {
        if (menuMusic.isPlaying==true)
        {
            menuMusic.Stop();
            soundButton.image.sprite = soundOffImage;

        }
        else if (menuMusic.isPlaying==false)
        {
            menuMusic.Play();
            soundButton.image.sprite = soundOnImage;
        }
    }
}
