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
	public int score;
	[SerializeField]
	public int scoreAmount;
	[SerializeField]
	private int particleCount;
	[SerializeField]
	private int range;
	private bool scoreAdded = false;

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
