using UnityEngine;


namespace Assets.Script {
    public class StartAudioManager : Singleton<StartAudioManager> {

        public AudioPlayer BackGroundPlayer;

        void Start() {

            BackGroundPlayer.Play("Ambient 1");
        }
    }

}
