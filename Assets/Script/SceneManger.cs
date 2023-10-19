using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace Assets.Script {
    public class SceneManager : Singleton<SceneManager> {
        public SceneAsset StartScene;

        void Start() {
            DontDestroyOnLoad(gameObject);
        }
        public void StartGame() {
            UnityEngine.SceneManagement.SceneManager.LoadScene(StartScene.name);

        }


    }

}
