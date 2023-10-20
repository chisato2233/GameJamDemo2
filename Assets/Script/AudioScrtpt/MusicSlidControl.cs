using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicSlidControl : MonoBehaviour {
    public Slider Slider { get; private set; }
    public AudioPlayer Player;
    
    void Start() {
        Slider=GetComponent<Slider>();
        Slider.onValueChanged.AddListener(OnValueChange);
    }

    public void OnValueChange(float val) {
        Player.Source.volume = val;
    }
}
