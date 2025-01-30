using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
	private GameObject player;
	[SerializeField] private string spawnPointString;
	[SerializeField] private GameObject spawnPoint;
	private bool _startingScene = true;

	public void Awake()
	{
		player = GameObject.Find("Player");
		SceneManager.sceneLoaded += OnSceneLoaded;
	}

	public void SceneChange(string scene, string spawn) 
	{
		_startingScene = false;
		SceneManager.LoadScene(scene);
		spawnPointString = spawn;
	}

	private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
		if (_startingScene) return;
		spawnPoint = GameObject.Find(spawnPointString);
		player.transform.position = spawnPoint.transform.position;
	}
	
	public void OnDestroy() { SceneManager.sceneLoaded -= OnSceneLoaded; }
}