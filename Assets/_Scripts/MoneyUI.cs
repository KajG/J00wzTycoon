using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MoneyUI : MonoBehaviour 
{
	[SerializeField]private Text moneyText;
	private float moneyValue;
	private Money moneyScript;

	private void Start()
	{
		moneyScript = GetComponent<Money> ();
		moneyScript.addMoney (100);
		moneyValue = moneyScript.getMoney;
		moneyText.text = "Money:  ℛℳ"+moneyValue;
	}
}
