using UnityEngine;

public class Trigger_SceneChange : MonoBehaviour
{
    private LevelManager _levelManager;
    public string sceneName;
    public string spawnPoint;
    
    private void Awake() {
        _levelManager = FindObjectOfType<LevelManager>();
    }

    public void OnTriggerEnter2D(Collider2D player) {
        _levelManager.SceneChange(sceneName, spawnPoint);
    }
}