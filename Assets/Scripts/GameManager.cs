using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public static bool GameIsOver;

	public GameObject gameOverUI;
	public GameObject completeLevelUI;
	public GameObject comingSoonUI;
	PlayerStats playerStats;

	void Start ()
	{
		Application.targetFrameRate = 60;
		QualitySettings.vSyncCount = 0;
		playerStats = PlayerStats.Instance;
		GameIsOver = false;
	}

	// Update is called once per frame
	void Update () {
		if (GameIsOver)
			return;

		if (playerStats.Lives <= 0)
		{
			EndGame();
		}
	}

	void EndGame ()
	{
		GameIsOver = true;
		gameOverUI.SetActive(true);
	}

	public void WinLevel ()
	{
		GameIsOver = true;
		if(SceneManager.GetActiveScene().name == "Level08")
		{
			comingSoonUI.SetActive(true);
			return;
		}
		completeLevelUI.SetActive(true);
	}

}
