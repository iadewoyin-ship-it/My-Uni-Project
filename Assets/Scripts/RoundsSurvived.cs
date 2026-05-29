using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoundsSurvived : MonoBehaviour {

	public Text roundsText;
	PlayerStats playerStats;
	WaitForSeconds waitTime;
	WaitForSeconds waitTime2;

	void Start()
	{
		playerStats = PlayerStats.Instance;
		waitTime = new WaitForSeconds(0.05f);
		waitTime2 = new WaitForSeconds(0.7f);
	}
	void OnEnable()
	{
		StartCoroutine(AnimateText());
	}

	IEnumerator AnimateText ()
	{
		roundsText.text = "0";
		int round = 0;

		yield return waitTime2;

		while (round < playerStats.Rounds)
		{
			round++;
			roundsText.text = round.ToString();

			yield return waitTime;
		}

	}

}
