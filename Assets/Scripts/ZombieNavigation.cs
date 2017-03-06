using UnityEngine;

public class ZombieNavigation : MonoBehaviour {

	public Transform target;

	UnityEngine.AI.NavMeshAgent agent;

	void Start () {
		agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
	}

	void Update () {
		if (target && !agent.hasPath) {
			agent.SetDestination(target.position);
		}
	}
}
