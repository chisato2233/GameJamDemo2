using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace Assets.Script {
    public class SceneManager : Singleton<SceneManager> {
        public SceneAsset GameScene;
        public Canvas LoadingCanvas;

        public float ChangeTime = 0.5f;

        void Awake() {
            DontDestroyOnLoad(gameObject);
            _animator = LoadingCanvas.gameObject.GetComponent<Animator>();
        }



        public void StartGame() {
            StartCoroutine(async_Loading());

        }

        IEnumerator async_Loading() {
            LoadingCanvas.gameObject.SetActive(true);
            StartAudioManager.Get().BackGroundPlayer.Stop();

            yield return new WaitForSeconds(ChangeTime);
            _animator.SetTrigger("Out");
            UnityEngine.SceneManagement.SceneManager.LoadScene(GameScene.name);
            
            yield return new WaitForSeconds(0.5f);
            LoadingCanvas.gameObject.SetActive(false);

        }


        private Animator _animator;
    }

}
