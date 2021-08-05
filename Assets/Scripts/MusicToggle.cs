using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

[RequireComponent(typeof(Toggle))]
public class MusicToggle : MonoBehaviour {

    Toggle musicToggle;

    void Start() {
        musicToggle = GetComponent<Toggle>();

        if (AudioListener.volume == 0) {
            musicToggle.isOn = false;
        }
    }

    public void ToggleAudioOnValueChange(bool audioIn) {
        if (audioIn) {
            AudioListener.volume = 1;
        }
        else {
            AudioListener.volume = 0;
        }
    }

}
