using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
	public Transform Target;
	Vector3 diff;
	float atan2;

	void Update()
	{
		diff = (Target.position - transform.position);
		atan2 = Mathf.Atan2(diff.y, diff.x);
		transform.rotation = Quaternion.Euler(0f, 0f, atan2 * Mathf.Rad2Deg -90);
	}
}

