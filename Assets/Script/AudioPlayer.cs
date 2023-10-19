using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[SerializeField]
public class AudioPlayer : MonoBehaviour {

    public List<AudioClip> ClipList=new List<AudioClip>();
    public AudioSource Source { get; private set; }

    void Awake() {
        Source= GetComponent<AudioSource>();
        _clips = new Dictionary<string, AudioClip>();
        foreach (var audioClip in ClipList) {
            _clips.Add(audioClip.name, audioClip);
        }
    }


    public void Play(string _name) {
        if (_clips.TryGetValue(_name, out var clip)) {
            Source.clip = clip;
            Source.Play();
        }
        else {
            Debug.LogError($"Do not find {_name}");
        }
    }
    
    private Dictionary<string, AudioClip> _clips;

}
