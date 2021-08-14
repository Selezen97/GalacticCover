using UnityEngine;
using System.Collections;

public class ShipTarget : MonoBehaviour
{
	public Sprite targetImage;
	void Start ()
	{
		IndicatorManager.instance.AddIndicator(gameObject, 
			Color.yellow, targetImage);
	}
}