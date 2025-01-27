using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
	public void NextScene() { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); }
	
	private void OnEnable() {
		ActionsManager.InteractEvent += NextScene;
	}
	private void OnDisable() {
		ActionsManager.InteractEvent -= NextScene;
	}

	public void Update()
	{
		if (Input.GetKeyDown(KeyCode.Alpha2)) SceneManager.LoadScene(1);
		if (Input.GetKeyDown(KeyCode.Alpha1)) SceneManager.LoadScene(0);
	}
}