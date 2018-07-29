using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySingleton : MonoBehaviour 
{

	//Instancia Unica Estatica
	private static MySingleton m_instance;

	//Propiedad para obtener la referencia al singleton
	public static MySingleton Instance
	{
		get
		{
			//si no hay instancia de la clase
			if (m_instance == null) {
				//Crear Objeto que contenra la instancia
				GameObject go = new GameObject ("MySingleton");
				//Agregar la instancia de la clase
				go.AddComponent<MySingleton> ();
				DontDestroyOnLoad (go);
			}

			return m_instance;
		}
		
	}

	void Awake()
	{

		if (m_instance) {
			Destroy (gameObject);
		} 
		else 
		{
			m_instance = this;
		}
	}

//================LOGICA DE DELEGADO======================//
	//Metodo para forzar a que exista el singleton para poderse suscribir
	public void Initialize()
	{
		//No hace nada
	}

//Delegado funciona como una especie de Template
//es como un metodo que no hace nada, pero tiene entradas y salidas
	public delegate void IntTemplate (int newInt);

//Para utilizarlo voy a crear evento con ese template
	//Lo utilizamos como meodo , pero no tiene definicion
	public static IntTemplate AddScoreHandler;
	public static IntTemplate DamagePlayerHandler;

	public void AddScore(int newScore)
	{
		AddScoreHandler(newScore);
	}
	public void DamagePlayer(int damageValue)
	{
		DamagePlayerHandler (damageValue);
	}

}
