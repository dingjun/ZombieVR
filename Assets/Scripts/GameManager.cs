using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public GameObject startMenu;
	public GameObject spawnerPoints;
	public GunShooting GunShooting;

	public void StartGame () {
		startMenu.SetActive(false);
		spawnerPoints.SetActive(true);
		GunShooting.enabled = true;
	}

	public void GameOver () {
		Destroy(spawnerPoints);
		GunShooting.enabled = false;
	}

	public void NewGame () {
		SceneManager.LoadScene("ZombieVR");
	}
}
