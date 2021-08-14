﻿using UnityEngine;
using System.Collections;

public class DamageTaking : MonoBehaviour
{

	public int hitPoints = 10;
	public GameObject destructionPrefab;
	public bool gameOverOnDestroyed = false;
	public void TakeDamage(int amount)
	{
		hitPoints -= amount;
		if (hitPoints <= 0)
		{
			Destroy(gameObject);
			if (destructionPrefab != null)
				Instantiate(destructionPrefab, 
                    transform.position, transform.rotation);
			if (gameOverOnDestroyed == true)
				GameManager.instance.GameOver();
		}
	}
}