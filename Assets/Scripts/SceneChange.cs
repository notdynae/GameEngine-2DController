using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger_SceneChange : MonoBehaviour
{
    [SerializeField] private LevelManager levelManager;
    [SerializeField] public string sceneName;
    [SerializeField] public string spawnPoint;
    
    private void Awake() {
        levelManager = FindObjectOfType<LevelManager>();
    }

    public void OnTriggerEnter2D(Collider2D player) {
        levelManager.SceneChange(sceneName, spawnPoint);
    }
}
