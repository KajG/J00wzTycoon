using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeController : MonoBehaviour {

	public ParticleScoreSystem score;
	int currentScore;
	bool buy1 = true;

	void Start () {
		score = GetComponent<ParticleScoreSystem> ();
		
	}
	
	void Update () {
		currentScore = score.score;
		if (currentScore >= 100 && buy1) 
		{
			score.scoreAmount += 2;
			buy1 = false;
		}


	}
}
