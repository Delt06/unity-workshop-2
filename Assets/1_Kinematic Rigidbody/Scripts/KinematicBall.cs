using UnityEngine;

namespace _1_Kinematic_Rigidbody.Scripts
{
	public class KinematicBall : MonoBehaviour
	{
		public Animator Animator;
		public Rigidbody Rigidbody;

		private void OnCollisionEnter(Collision other)
		{
			if (Rigidbody.isKinematic)
			{
				var lastMotion = Rigidbody.position - _lastPosition;
				var velocity = lastMotion / Time.deltaTime;
				Animator.enabled = false;
				Rigidbody.isKinematic = false;
				Rigidbody.velocity = velocity;
			}
		}

		private void FixedUpdate()
		{
			_lastPosition = Rigidbody.position;
		}

		private Vector3 _lastPosition;
	}
}