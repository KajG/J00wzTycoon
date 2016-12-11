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
	private int scoreAmount;
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
		ScoreCheck();
		score += scoreAmount;
		particleSystem.Emit (scoreAmount);
	}
	void ScoreCheck(){
		int newNumber = score / range;
			switch(newNumber){
		case(1):
			scoreAmount += 2;
			scoreAdded = true;
			break;
		case(2):
			scoreAmount += 4;
			break;
		default:
			break;
		}
	}
}
