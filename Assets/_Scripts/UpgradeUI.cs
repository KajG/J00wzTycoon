using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeUI : MonoBehaviour 
{
	private UpgradeController upgrades;
	[SerializeField]private Button upgrade;
	[SerializeField]private int upgradePrice;

	private void Start()
	{
		upgrades = GetComponent<UpgradeController> ();
		upgrade.onClick.AddListener (delegate(){upgrades.upgrade(upgradePrice);});
	}
}
