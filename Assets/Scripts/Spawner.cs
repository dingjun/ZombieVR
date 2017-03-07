using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject zombie;
	public Transform player;
	public float spawnInterval = 8f;

	float spawnVariance;

	void Start () {
		spawnVariance = spawnInterval * 0.5f;
		Invoke("Spawn", spawnInterval + Random.Range(-spawnVariance, spawnVariance));
	}

	void Update () {
		if (spawnInterval > 1f) {
			float timeReduction = Time.deltaTime / 50f;
			spawnInterval = Mathf.Max(1f, spawnInterval - timeReduction);
			spawnVariance = spawnInterval * 0.5f;
		}
	}

	void Spawn () {
		GameObject zombieObj = Instantiate(zombie, transform.position, transform.rotation) as GameObject;
		zombieObj.transform.parent = transform;
		zombieObj.GetComponent<ZombieAI>().target = player;
		
		Invoke("Spawn", spawnInterval + Random.Range(-spawnVariance, spawnVariance));
	}
}
