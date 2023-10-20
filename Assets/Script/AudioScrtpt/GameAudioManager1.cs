using UnityEngine;
using UnityEngine.Events;


namespace Assets.Script {
    public class GameAudioManager1 : Singleton<GameAudioManager1> {

        public AudioPlayer BackGroundPlayer;
        
        void Start() {
            BackGroundPlayer.Play("Ambient 2");
        }
    }

}
