using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawner : MonoBehaviour
{
    public GameObject powerUp;
    public float timeBetweenSpawn = 30f;
    


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());

    }

    // Update is called once per frame




    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(timeBetweenSpawn);
        SpawnPowerUp();
        StartCoroutine(Spawn());

    }

    void SpawnPowerUp()
    {
        Debug.Log("PowerUp");
        Vector3 screenPosition = Camera.main.ScreenToWorldPoint(new Vector3(Random.Range(0, Screen.width), Random.Range(0, Screen.height), Camera.main.farClipPlane / 2));
        Instantiate(powerUp, screenPosition, Quaternion.identity);
    }


}
