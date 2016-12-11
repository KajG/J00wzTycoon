using UnityEngine;
using System.Collections;

public class Money : MonoBehaviour 
{
	private float moneyValue{ get; set;}
	public float getMoney{get{return moneyValue;}}

	public void addMoney(float amount)
	{
		moneyValue += amount;
	}

	public void spendMoney(float amount)
	{
		moneyValue -= amount;
	}
}
