using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreUI : MonoBehaviour {
	[SerializeField]
	private ParticleScoreSystem score;
	[SerializeField]
	private Text scoreText;


	void Start () {
		
	}
	
	void Update () {
		scoreText.text = ("Jews killed: " + score.score);


	}
}
