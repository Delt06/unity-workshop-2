using System;
using UnityEngine;

namespace _5_Vectors
{
	public class MoveAt1 : MonoBehaviour
	{
		public Transform Target;
		public float Speed;
		
		private void Update()
		{
			var direction = (Target.position - transform.position).normalized;
			transform.position += Speed * Time.deltaTime * direction;
		}
	}
}