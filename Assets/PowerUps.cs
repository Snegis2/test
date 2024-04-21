using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    public GameObject[] powerups;
    void Start()
    {
        StartCoroutine(SpawnPowerup());
    }

    IEnumerator SpawnPowerup()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            if(powerups.Length > 0 )
            {
                int randomIndex = Random.Range(0, powerups.Length);
                Vector3 spawn = new (Random.Range(-10, 10), Random.Range(-10, 10), 0);
                Instantiate(powerups[randomIndex], spawn, Quaternion.identity);
            }           
        }
    }
}
