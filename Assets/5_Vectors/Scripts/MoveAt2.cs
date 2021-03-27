using UnityEngine;

namespace _5_Vectors
{
	public class MoveAt2 : MonoBehaviour
	{
		public Transform Target;
		public float Speed;
		
		private void Update()
		{
			transform.position = Vector3.MoveTowards(transform.position, Target.position, Speed * Time.deltaTime);
		}
	}
}