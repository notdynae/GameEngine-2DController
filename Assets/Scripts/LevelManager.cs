using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
	[SerializeField] private GameObject player;
	[SerializeField] private string spawnPointString;
	[SerializeField] private GameObject spawnPoint;

	public void Awake()
	{
		player = GameObject.Find("Player");
	}

	public void SceneChange(string scene, string spawn) {
		SceneManager.LoadScene(scene);
		spawnPointString = spawn;
		Debug.Log(spawnPointString);
	}

	public void OnSceneLoaded(Scene scene, LoadSceneMode arg1)
	{
		Debug.Log($"OnSceneLoaded, {spawnPointString}");
		spawnPoint = GameObject.Find(spawnPointString);
		player.transform.position = spawnPoint.transform.position;
	}

	public void OnEnable() { SceneManager.sceneLoaded += OnSceneLoaded; }
	// public void OnDisable() { SceneManager.sceneLoaded -= OnSceneLoaded; }

}