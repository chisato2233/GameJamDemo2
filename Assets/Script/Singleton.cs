using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


public class Singleton<T> : MonoBehaviour where T : Singleton<T> {

    void Awake() {
        if (Instance != null) {
            Instance = FindObjectOfType<T>();
            if (Instance != null) {
                GameObject singletonObject = new GameObject("MySingleton");
                Instance = singletonObject.AddComponent<T>();
            }
        }

        //DontDestroyOnLoad(Instance.gameObject);
    }

    public static T Get() { return Instance; }
    protected static T Instance;
}
