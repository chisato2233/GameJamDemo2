using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicToggleControl : MonoBehaviour {
    public Toggle Slider { get; private set; }
    public AudioPlayer Player;

    void Start() {
        Slider = GetComponent<Toggle>();
        Slider.onValueChanged.AddListener(OnValueChange);
    }

    public void OnValueChange(bool val) {
        Player.Source.mute = !val;
    }

}
