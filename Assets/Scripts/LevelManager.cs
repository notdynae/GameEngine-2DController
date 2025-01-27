using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
	[SerializeField] private GameObject player;
	[SerializeField] private GameObject spawnPoint;

	public void LoadNewScene(int index)
	{
		SceneManager.LoadScene(index);
	}

	public void Awake()
	{
		player = GameObject.Find("Player");
	}

	private void OnSceneLoaded(Scene scene, LoadSceneMode arg1)
	{
		spawnPoint = GameObject.FindGameObjectWithTag("SpawnPoint");
		player.transform.position = spawnPoint.transform.position;
	}

	public void OnEnable() { SceneManager.sceneLoaded += OnSceneLoaded; }
	public void OnDisable() { SceneManager.sceneLoaded -= OnSceneLoaded; }

	public void Update()
	{
		if (Input.GetKeyDown(KeyCode.Alpha1)) {
			LoadNewScene(0);
		}
		if (Input.GetKeyDown(KeyCode.Alpha2)) {
			LoadNewScene(1);
		}
	}
}