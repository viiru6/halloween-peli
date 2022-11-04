using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class spawnmanager : MonoSingleton<spawnmanager>
{
    public static bool alive = false;
    public List<Transform> spawnpoint = new List<Transform>();
    public List<GameObject> spawnPrefabs = new List<GameObject>();
    public void Spawn(int spawnPrefabIndex)
    {
        Spawn(spawnPrefabIndex, 0);
    }
    public void Spawn(int spawnPrefabIndex,int spawnPointIndex)
    {
        Instantiate(spawnPrefabs[spawnPrefabIndex], spawnpoint[spawnPointIndex].position, spawnpoint[spawnPointIndex].rotation);
    }

    public static bool aaltoAktiivinen = false;
    public float period = 20f;
    WaitForSeconds waitForSeconds = new WaitForSeconds(1);

    IEnumerator aika()
    {
        yield return waitForSeconds;
    }

    public void spawnaus()
    {
        int r2 = Random.Range(0, 13);
        int r1 = Random.Range(0, 2);
        for (int d = 0; d < 10; d++)
        {
            Spawn(r1, r2);
        }
        Spawn(2, r2);
    }
    public int kello;
    private void Update()
    {
        kello++;
        if (alive)
        {
            if (kello == 100)
            {
                kello = 0;
                spawnaus();
                
            }
        }
        else
        {
            Debug.Log("pelaaja on kuollut eli ei spawnata lisää");
        }
        
    }
}
