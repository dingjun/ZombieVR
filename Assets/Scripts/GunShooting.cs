using UnityEngine;

public class GunShooting : MonoBehaviour {

	public ParticleSystem vfx;		// shooting impact vfx

	AudioSource shootingAudio;

	void Start () {
		shootingAudio = GetComponent<AudioSource>();
	}

	void Update () {
		if (Input.GetButtonDown("Fire1")) {
			shootingAudio.Stop();
			shootingAudio.Play();

			RaycastHit hit;

			if (Physics.Raycast(transform.position, transform.forward, out hit, 100f)) {
				vfx.transform.position = hit.point;
				vfx.transform.rotation = Quaternion.Euler(270f, 0, 0);
				vfx.Stop();
				vfx.Play();

				if (hit.transform.tag == "Zombie") {
					hit.transform.GetComponent<ZombieAI>().Die();
				}
			}
		}
	}
}
