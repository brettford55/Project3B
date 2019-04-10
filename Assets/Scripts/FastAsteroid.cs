using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FastAsteroid : MonoBehaviour
{
    private Transform player;
    public float speed;
    public float health = 5;
    public int pointsForKill = 5;
    public GameObject particle;
    public Rigidbody2D rb;



    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = (GameObject.FindGameObjectWithTag("Player").transform.position - transform.position).normalized * speed;
    }

    void Update()
    {
        if (health <= 0)
            Die();
    }


    public void Die()
    {
        Player.currentScore += pointsForKill;
        FindObjectOfType<SFXManager>().Play("AsteroidDeath");
        Destroy(gameObject);
        GameObject part = Instantiate(particle, this.transform.position, Quaternion.identity);
        part.GetComponent<ParticleSystem>().Play();
        Destroy(part, 1);

    }
}
