using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeUI : MonoBehaviour 
{
	private UpgradeController upgrades;
	[SerializeField]private Button upgrade;

	private void Start()
	{
		upgrades = GetComponent<UpgradeController> ();
		upgrade.onClick.AddListener (delegate(){upgrades.upgrade(100);});
	}
}
