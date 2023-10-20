using UnityEngine;


namespace Assets.Script {
    public class StartAudioManager : Singleton<StartAudioManager> {

        public AudioPlayer BackGroundPlayer;

        void Start() {
            BackGroundPlayer.PlayInfoLoop("m_sys_title_intro", "m_sys_title_loop");
        }
    }

}
