using UnityEngine;
using System.Collections;

public class Money : MonoBehaviour 
{
	private enum currency{Reichsmark};
	private float moneyValue{ get; set;}
	public float getMoney{get{return moneyValue;}}


	private void Start()
	{
		moneyValue = 100;
	}

	public void addMoney(float amount)
	{
		moneyValue += amount;
	}

	public void spendMoney(float amount)
	{
		moneyValue -= amount;
	}
}
