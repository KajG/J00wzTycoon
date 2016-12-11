using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleScoreSystem : MonoBehaviour {
	//[SerializeField]
	private ParticleSystem particleSystem;
	[SerializeField]
	private int burstDelay;
	[SerializeField]
	private int burstAmount;
	[SerializeField]
	private int score;
	[SerializeField]
	private int scoreAmount;
	[SerializeField]
	private int particleCount;

	void Start () {
		particleSystem = GetComponent<ParticleSystem> ();
	}

	void Update () {
		//int particleCount = particleSystem.GetParticles(ParticleSystem.Particle[] oparticlees,;
	}
	public void AddPoint(){
		score += scoreAmount;
		particleSystem.Emit (scoreAmount);
	}
}
