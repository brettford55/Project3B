using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponCont : MonoBehaviour
{
    public float fireRate;
    public float powerFireRate;

    private float timeUntilFire = 0;

   
   

    public Transform firePoint;
    public GameObject bullet;
    public GameObject powerUp;

    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && Time.time > timeUntilFire && Player.powerBool == false)
        {
            timeUntilFire = Time.time + 1 / fireRate;
            Shoot();
        }
        else if (Input.GetKeyDown("space") && Time.time > timeUntilFire && Player.powerBool == true)
        {
            timeUntilFire = Time.time + 1 / powerFireRate;
            PowerUpShoot();
        }

    }

    void Shoot()
    {
        Instantiate(bullet, firePoint.position, firePoint.rotation);
        FindObjectOfType<SFXManager>().Play("Laser");
    }

    void PowerUpShoot()
    {
        Instantiate(powerUp, firePoint.position, firePoint.rotation);
        FindObjectOfType<SFXManager>().Play("Laser");
    }

    public void SetVolume(float volume)
    {
        AudioSource audioSource = FindObjectOfType<SFXManager>().GetSound("Laser");
        audioSource.volume = volume;
    }

}
