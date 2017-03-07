using UnityEngine;

public class PlayerHealth : MonoBehaviour {

	public GameManager gm;
	public Transform gameOver;

	void OnTriggerEnter (Collider other) {
		if (other.tag == "Zombie") {
			transform.parent = gameOver;
			transform.localPosition = Vector3.zero;
			transform.localRotation = Quaternion.identity;
			transform.GetChild(0).localRotation = Quaternion.identity;
			gm.GameOver();
			return;
		}
	}
}
