using UnityEngine;

namespace _4_Animator.Scripts
{
	public class InputAnimations : MonoBehaviour
	{
		public Animator Animator;

		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.LeftArrow))
				Animator.SetTrigger("Punch Left");
			else if (Input.GetKeyDown(KeyCode.RightArrow))
				Animator.SetTrigger("Punch Right");
		}
	}
}