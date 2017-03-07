using UnityEngine;

public class PlayerHealth : MonoBehaviour {

	public GameManager gm;
	public Transform gameOver;

	void OnTriggerEnter (Collider other) {
		if (other.tag == "Zombie") {
			gm.GameOver();
		}
	}
}
