using UnityEngine;


namespace Assets.Script {
    public class AudioManager : Singleton<AudioManager> {

        public GameObject BackGroundPlayer;

        void Start() {
            //DontDestroyOnLoad(gameObject);
            if (!BackGroundPlayer) Debug.Log("BackGroundPlayer is null");

            BackGroundPlayer.GetComponent<AudioPlayer>().Play("Ambient 1");
        }
    }

}
