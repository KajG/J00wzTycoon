using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeController : MonoBehaviour 
{
    private ParticleScoreSystem score;
    private Money moneyScript;
    private bool buy1 = true;
    [SerializeField]private int upgradePrice;

    void Start () 
    {
        score = GameObject.FindObjectOfType<ParticleScoreSystem> ();
        moneyScript = GetComponent<Money> ();
    }

    public void upgrade (int cost)
    {
        if (moneyScript.getMoney >= cost && buy1) 
        {
            moneyScript.spendMoney (cost);
            score.scoreAmount += 2;
            buy1 = false;
        }
    }
}