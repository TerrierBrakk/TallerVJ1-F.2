using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class barravida : MonoBehaviour {
	

	public Image vida;
	float hp,maxhp=100f;
	public AudioSource Muerte;
	public AudioClip Mori;
	public MeshRenderer Escudo;

	// Use this for initialization
	void Start () 
	{
		hp=maxhp;
		
	}
	
	void LaMuerte()
	{
		Debug.Break();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(hp <= 50)
		{
			Escudo.enabled = false;
		}
		
		if(hp <= 0)
		{
			print("Perdiste");
			Muerte.PlayOneShot(Mori);
			Invoke("LaMuerte", 1f);
		}
	}
	void damage(float amount){
		hp=Mathf.Clamp(hp-amount,0f,maxhp);
		vida.transform.localScale=new Vector2(hp/maxhp,1);
	}
}
