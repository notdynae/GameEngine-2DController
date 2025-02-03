using UnityEngine;

public class Trigger_SceneChange : MonoBehaviour
{
    [SerializeField] private string sceneName;
    [SerializeField] private string spawnPoint;

    public void OnTriggerEnter2D(Collider2D player) {
        GameManager.Instance.levelManger.SceneChange(sceneName, spawnPoint);
    }
}