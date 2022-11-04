using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/* Keeps track of the player */

public class playerManager : MonoBehaviour
{

	#region Singleton

	public static playerManager instance;

	void Awake()
	{
		instance = this;
	}

	#endregion

	public GameObject player;

	public void KillPlayer()
	{
		GameObject.Instantiate(Resources.Load("prefabs/kuolemaruutu"));
	}

}