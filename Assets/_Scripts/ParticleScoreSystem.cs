using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleScoreSystem : MonoBehaviour 
{
	private ParticleSystem particleSystem;
	private Money moneyScript;
	[SerializeField]private int burstDelay;
	[SerializeField]private int burstAmount;
	[SerializeField]public int scoreAmount;
	[SerializeField]private int particleCount;
	[SerializeField]private int range;

	void Start () 
	{
		particleSystem = GetComponent<ParticleSystem> ();
		moneyScript = GameObject.FindGameObjectWithTag(Tags.gameController).GetComponent<Money> ();
	}

	private void AddPoint()
	{
		moneyScript.addMoney(scoreAmount);
		particleSystem.Emit (scoreAmount);
	}

	private void Update()
	{
		if (Input.GetMouseButtonDown (0))
		{
			AddPoint ();
		}
	}
}
