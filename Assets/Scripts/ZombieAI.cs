using UnityEngine;

public class ZombieAI : MonoBehaviour {

	public Transform target;

	Rigidbody rb;
	Animator am;
	Collider cl;                        // head collider
	UnityEngine.AI.NavMeshAgent agent;

	void Start () {
		rb = GetComponent<Rigidbody>();
		am = GetComponent<Animator>();
		cl = transform.GetChild(0).GetComponent<Collider>();
		agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
	}

	void Update () {
		float sqrSpeed = rb.velocity.sqrMagnitude;
		am.SetFloat("sqrSpeed", sqrSpeed);

		// attack if close to target
		float distance = Mathf.Abs(transform.position.x - target.position.x);
		if (distance < 2.5f) {
			am.SetBool("attack", true);
		}

		if (target && !agent.hasPath) {
			agent.SetDestination(target.position);
		}
	}

	public void Die () {
		am.SetTrigger("die");
		cl.enabled = false;         // prevent getting shot again
		agent.Stop();               // stop moving
		Destroy(gameObject, 1f);
	}
}
