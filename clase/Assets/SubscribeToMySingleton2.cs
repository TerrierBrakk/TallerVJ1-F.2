using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubscribeToMySingleton2 : MonoBehaviour {
	

	protected void Start()
	{
		MySingleton.Instance.Initialize ();
	}

	//Suscribirme al evento Singleton

	void OnEnable()
	{
		MySingleton.DamagePlayerHandler += OnPlayerDamage;
	}

	void OnDisable()
	{
		MySingleton.DamagePlayerHandler -= OnPlayerDamage;
	}

	void OnDestroy()
	{
		MySingleton.DamagePlayerHandler += OnPlayerDamage;
	}

	//Este metodo debe coincidir con la template del Delegado(y el evento)
	public void OnPlayerDamage(int newScore)
	{
		iTween.ShakePosition (gameObject, Vector3.one*0.1f, 0.5f);
	}
}
	