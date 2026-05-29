using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour {

	public float startSpeed = 10f;

	[HideInInspector]
	public float speed;

	public float startHealth = 100;
	private float health;

	public int worth = 50;

	public GameObject deathEffect;

	[Header("Unity Stuff")]
	public Image healthBar;

	private bool isDead = false;
	float startSpeedTemp;

	public bool isUnstoppable = false;

	void Start ()
	{
		speed = startSpeed;
		health = startHealth;
		startSpeedTemp = speed;
	}

	public void TakeDamage (float amount)
	{
		health -= amount;

		healthBar.fillAmount = health / startHealth;

		if (health <= 0 && !isDead)
		{
			Die();
		}
	}

	public void Slow (float pct)
	{
		if(isUnstoppable) return;

		speed = startSpeed * (1f - pct);
	}

	public void Freeze(float freeze)
	{
		if(isUnstoppable) return;
		
		startSpeed = 0;
		speed = 0;
		CancelInvoke("SetSpeedToNormal");
		Invoke("SetSpeedToNormal",freeze);
	}

	void SetSpeedToNormal()
	{
		startSpeed = startSpeedTemp;
		speed = startSpeed;
	}

	void Die ()
	{
		isDead = true;

		PlayerStats.Instance.Money += worth;

		GameObject effect = (GameObject)Instantiate(deathEffect, transform.position, Quaternion.identity);
		Destroy(effect, 5f);

		WaveSpawner.EnemiesAlive--;

		Destroy(gameObject);
	}

}
