using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(playerStats))]
public class CharacterCombat : MonoBehaviour
{

	public float attackSpeed = 1f;
	private float attackCooldown = 0f;

	public float attackDelay = .6f;

	public event System.Action OnAttack;

	playerStats myStats;

	void Start()
	{
		myStats = GetComponent<playerStats>();
	}

	void Update()
	{
		attackCooldown -= Time.deltaTime;
	}

	public void Attack(playerStats targetStats)
	{
		if (attackCooldown <= 0f)
		{
			StartCoroutine(DoDamage(targetStats, attackDelay));

			if (OnAttack != null)
				OnAttack();

			attackCooldown = 1f / attackSpeed;
		}

	}

	IEnumerator DoDamage(playerStats stats, float delay)
	{
		yield return new WaitForSeconds(delay);

		stats.TakeDamage(myStats.damage.GetValue());
	}

}