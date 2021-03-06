using UnityEngine;
using System.Collections;

public class ShipWeapons : MonoBehaviour
{
	public GameObject shotPrefab;
	public void Awake()
	{
		InputManager.instance.SetWeapons(this);
	}
	public void OnDestroy()
	{
		if (Application.isPlaying == true)
			InputManager.instance.RemoveWeapons(this);
	}
	public Transform[] firePoints;
	private int firePointIndex;
	public void Fire()
	{
		if (firePoints.Length == 0) 
			return;
		var firePointToUse = firePoints[firePointIndex];
		Instantiate(shotPrefab, 
			firePointToUse.position, 
			firePointToUse.rotation);
		var audio = firePointToUse.GetComponent<AudioSource>();
		if (audio)
			audio.Play();
		firePointIndex++;
		if (firePointIndex >= firePoints.Length)
			firePointIndex = 0;
	}
}
