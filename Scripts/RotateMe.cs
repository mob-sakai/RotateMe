using UnityEngine;

namespace Coffee.RotateMe
{
	public class RotateMe : MonoBehaviour
	{
		public float angularVelocity = 10;
		void Update ()
		{
			var rot = Quaternion.AngleAxis (angularVelocity * Time.deltaTime, Vector3.up);
			transform.localRotation = rot * transform.localRotation;
			Debug.Log("fix1");
			Debug.Log("fix2");
			Debug.Log("add feat");
			Debug.Log("add breaking change");
			Debug.Log("add breaking change");
			Debug.Log("add breaking change for v4");
		}
	}
}
