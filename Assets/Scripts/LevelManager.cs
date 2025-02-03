using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
	[SerializeField] private string spawnPointString;
	[SerializeField] private GameObject spawnPoint;
	
	public void SceneChange(string scene, string spawn) 
	{
		spawnPointString = spawn;
		SceneManager.LoadScene(scene);
		SceneManager.sceneLoaded += OnSceneLoaded;
	}

	private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
		spawnPoint = GameObject.Find(spawnPointString);
		GameManager.Instance.player.transform.position = spawnPoint.transform.position;
		SceneManager.sceneLoaded -= OnSceneLoaded;
	}
}