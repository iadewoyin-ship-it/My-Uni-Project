using UnityEngine;
using UnityEngine.UI;

public class LivesUI : MonoBehaviour {

	public Text livesText;
	public PlayerStats playerStats;

	void Start()
	{
		playerStats = PlayerStats.Instance;
	}
	void Update () {
		livesText.text = playerStats.Lives + " LIVES";
	}
}
