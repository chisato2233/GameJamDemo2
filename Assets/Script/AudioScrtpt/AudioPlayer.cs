using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.LowLevel;


public class AudioPlayer : MonoBehaviour {

        public List<AudioClip> ClipList = new List<AudioClip>();
        public AudioSource Source { get; private set; }

        void Awake() {
            Source = GetComponent<AudioSource>();
            _clips = new Dictionary<string, AudioClip>();
            foreach (var audioClip in ClipList) {
                _clips.Add(audioClip.name, audioClip);
            }
        }

    

        public void Play(string _name) {
            if (_clips.TryGetValue(_name, out var clip)) play(clip);
            else Debug.LogError($"Do not find {_name}");
        }


        public void PlayLoop(string _name) {
            if (_clips.TryGetValue(_name, out var clip)) playLoop(clip);
            else Debug.LogError($"Do not find {_name}");
        }


        public void PlayInfoLoop(string _info, string _loop) {
            if (_clips.TryGetValue(_info, out var infoClip)) {
                if (_clips.TryGetValue(_loop, out var loopClip)) {
                    StartCoroutine(async_PlayInfoLoop(infoClip, loopClip));
                    
                }
                else Debug.LogError($"Do not find {_loop}");
            }
            else Debug.LogError($"Do not find {_info}");
        }


        public void Stop() { Source.Stop(); }
        public void Pause() { Source.Pause(); }


        // private-------------------------------------------------------------------------------------------
        private void play(AudioClip _clip) {
            Source.clip = _clip;
            Source.loop = false;
            Source.Play();
        }
        private void playLoop(AudioClip _clip) {
            Source.clip = _clip;
            Source.loop = true;
            Source.Play();
        }
        private IEnumerator async_PlayInfoLoop(AudioClip _info, AudioClip _loop) {
            play(_info);
            _loop.LoadAudioData();
           
            yield return new WaitWhile(()=>Source.isPlaying);
            playLoop(_loop);
            
        }

        private Dictionary<string, AudioClip> _clips;

    }


