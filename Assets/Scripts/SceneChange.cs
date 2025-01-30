using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger_SceneChange : MonoBehaviour
{
    [SerializeField] private string sceneName;
    [SerializeField] private string spawnPoint;

    public void OnTriggerEnter(Collider player) {
        throw new NotImplementedException();
    }
}
