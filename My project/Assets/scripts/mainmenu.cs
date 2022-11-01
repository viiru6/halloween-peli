using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    GameObject game;
    private void Start()
    {
        game = gameObject;
        game.SetActive(false);
    }
    public void poistu()
    {
        Application.Quit();
        Debug.Log("toiimi");
    }
    public void pelaa()
    {
        GameObject menu;
        menu = GameObject.Find("mainmenu(Clone)");
        menu.SetActive(false); 
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false; 
        game = GameObject.Find("game");
        game.SetActive(true);
    }
}