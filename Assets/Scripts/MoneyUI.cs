using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MoneyUI : MonoBehaviour {

	public Text moneyText;
	PlayerStats playerStats;

	void Start()
	{
		playerStats = PlayerStats.Instance;
	}
	void Update () {
		moneyText.text = "$" + playerStats.Money;
	}
}
