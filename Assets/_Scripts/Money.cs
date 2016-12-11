using UnityEngine;
using System.Collections;

public class Money : MonoBehaviour 
{
	private MoneyUI ui;
	private float moneyValue{ get; set;}
	public float getMoney{get{return moneyValue;}}

	private void Start()
	{
		ui = GetComponent<MoneyUI> ();
		this.addMoney (100);
	}

	public void addMoney(float amount)
	{
		moneyValue += amount;
		ui.updateUI();
	}

	public void spendMoney(float amount)
	{
		moneyValue -= amount;
		ui.updateUI ();
	}
}
