using System;
using UnityEngine;

namespace _5_Vectors.Scripts
{
	public class DotColor : MonoBehaviour
	{
		public Transform Transform1;
		public Transform Transform2;

		private void Update()
		{
			var meshRenderer = GetComponent<MeshRenderer>();
			var material = meshRenderer.material;
			var dot = Vector3.Dot(Transform1.forward, Transform2.forward); // [-1, 1] 
			dot += 1; // [0, 2]
			dot /= 2; // [0, 1]
			material.color = Color.yellow * dot;
		}
	}
}