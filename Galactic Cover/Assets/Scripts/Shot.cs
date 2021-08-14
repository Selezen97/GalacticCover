using UnityEngine;
using System.Collections;

public class Shot : MonoBehaviour
{

	public float speed = 100.0f,life = 5.0f;
	void Start()
	{
		Destroy(gameObject, life);
	}

	void Update ()
	{
		transform.Translate(Vector3.forward * speed  * Time.deltaTime);
	}
}
