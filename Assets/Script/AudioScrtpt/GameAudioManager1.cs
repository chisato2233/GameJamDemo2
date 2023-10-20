using UnityEngine;
using UnityEngine.Events;


namespace Assets.Script {
    public class GameAudioManager1 : Singleton<GameAudioManager1> {

        public AudioPlayer BackGroundPlayer;
        
        void Start() {
            BackGroundPlayer.PlayInfoLoop("m_sys_void_intro", "m_sys_void_loop");
        }
    }

}
