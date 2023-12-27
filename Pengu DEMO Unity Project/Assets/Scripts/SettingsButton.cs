using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsButton : MonoBehaviour
{
    public Button settingsButton;
    public GameObject hiddenSoundButton, hiddenInfoButton;

    private bool isHidden = false;

    void Start()
    {
        // Ensure the hiddenButton is initially hidden.
        hiddenSoundButton.SetActive(false);
        hiddenInfoButton.SetActive(false);

        // Add a listener to the settings button.
        settingsButton.onClick.AddListener(ToggleHiddenButton);
    }

    void ToggleHiddenButton()
    {
        // Toggle the visibility of the hiddenButton.
        isHidden = !isHidden;
        hiddenSoundButton.SetActive(isHidden);
        hiddenInfoButton.SetActive(isHidden);
    }
}
