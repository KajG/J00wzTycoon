using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleScoreSystem : MonoBehaviour {
	[SerializeField]
	private ParticleSystem particleSystem;
	[SerializeField]
	private int burstDelay;
	[SerializeField]
	private int burstAmount;

	void Start () {
		var em = particleSystem.emission;
		em.enabled = true;
		em.SetBursts (new ParticleSystem.Burst[]  { 
			new ParticleSystem.Burst (burstDelay, 100)
		});	

	}
	
	void Update () {
		
	}
	void AddPoint(){


	}
}
