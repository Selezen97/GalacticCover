using UnityEngine;
using System.Collections;

public class ShipThrust : MonoBehaviour
{

	public float speed = 5.0f;
	void Update ()
	{
		var offset = Vector3.forward * Time.deltaTime * speed;
		this.transform.Translate(offset);
	}
}