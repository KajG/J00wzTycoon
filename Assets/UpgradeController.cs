using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeController : MonoBehaviour {

	public ParticleScoreSystem score;
	int currentScore;
	bool buy1 = true;
	[SerializeField]
	private int upgradePrice;

	void Start () {
		score = GetComponent<ParticleScoreSystem> ();
	}
	
	void Update () {
		//currentScore = score.score;
	}
	public void BuyUpgrade1 ()
	{
		if (currentScore >= upgradePrice && buy1) 
		{
			score.score -= 100;
			score.scoreAmount += 2;
			buy1 = false;
		}
	}
}
