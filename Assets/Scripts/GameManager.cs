using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public GameObject startMenu;
	public GameObject hospital;
	public GameObject spawnerPoints;
	public Transform endMenu;
	public Transform playerEye;

	GunShooting gunShooting;

	void Start () {
		gunShooting = playerEye.GetComponent<GunShooting>();
	}

	public void StartGame () {
		startMenu.SetActive(false);
		spawnerPoints.SetActive(true);
		gunShooting.enabled = true;
	}

	public void GameOver () {
		Destroy(hospital);
		Destroy(spawnerPoints);
		gunShooting.enabled = false;

		// show game over menu in front of player
		endMenu.position = playerEye.position + playerEye.forward;
		endMenu.rotation = playerEye.rotation;
	}

	public void NewGame () {
		SceneManager.LoadScene("ZombieVR");
	}
}
