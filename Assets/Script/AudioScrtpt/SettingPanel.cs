using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Assets.Script {
    public class SettingPanel : MonoBehaviour {
        private Animator _animator;
        
        void Start() {
            _animator = GetComponent<Animator>();
        }


        public void OpenSettings() {
            gameObject.SetActive(true);
            
        }

        public void CloseSettings() {
            _animator.SetTrigger("Close");
            StartCoroutine(async_CloseSettings());
        }

        IEnumerator async_CloseSettings() {
            yield return new WaitForSeconds(0.1f);
            gameObject.SetActive(false);
        }
        
        
    }

}
