using UnityEngine;
using System.Collections;

public class PlayerStats : MonoBehaviour {

	public static PlayerStats Instance {get;set;}
	public int Money;
	public int startMoney = 400;

	public int Lives;
	public int startLives = 20;

	public int Rounds;


	void Awake()
	{
		if(Instance != null) Destroy(this.gameObject);
		else Instance = this;
	}

	void Start ()
	{
		Money = startMoney;
		Lives = startLives;

		Rounds = 0;
	}

}
