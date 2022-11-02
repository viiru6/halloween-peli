using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class init : MonoBehaviour
{
    void Start()
    {
        GameObject.Instantiate(Resources.Load("prefabs/mainmenu"));
    }
}
