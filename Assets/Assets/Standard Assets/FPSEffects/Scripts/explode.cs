using UnityEngine;
using System.Collections;

public class explode : MonoBehaviour {

	public UnityEngine.GameObject explosionEffect;
	public Transform  explosionEffectLocation;
	public float health;

	private bool bExploded;
	private Game	gameController;

	void Awake()
	{
		bExploded = false;

        UnityEngine.GameObject goTemp = UnityEngine.GameObject.FindGameObjectWithTag ("GameController");
		gameController = goTemp.GetComponent<Game> ();
	}

	void Update () 
	{
	
		if (health <= 0 && bExploded == false )
		{
			bExploded = true;
			Instantiate (explosionEffect, explosionEffectLocation.position, Quaternion.LookRotation( Vector3.up ) );
			Destroy (gameObject );

			gameController.BarrelDestroyed();
		}
	}



	public void TakeDamage( float flDamage )
	{
		health -= flDamage;
	}
}
