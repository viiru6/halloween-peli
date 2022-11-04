using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Handles interaction with the Enemy */

[RequireComponent(typeof(playerStats))]
public class Enemy : Interactable
{

	playerManager playerManager;
	playerStats myStats;

	void Start()
	{
		playerManager = playerManager.instance;
		myStats = GetComponent<playerStats>();
	}

	public override void Interact()
	{
		base.Interact();
		CharacterCombat playerCombat = playerManager.player.GetComponent<CharacterCombat>();
		if (playerCombat != null)
		{
			playerCombat.Attack(myStats);
		}
	}

}