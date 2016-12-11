using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MoneyUI : MonoBehaviour 
{
	[SerializeField]private Text moneyText;
	private Money moneyScript;

	private void Start()
	{
		this.moneyScript = GetComponent<Money> ();
		this.updateUI ();
	}

	public void updateUI()
	{
		this.moneyText.text = "Money:  ℛℳ"+this.moneyScript.getMoney;
	}
}
