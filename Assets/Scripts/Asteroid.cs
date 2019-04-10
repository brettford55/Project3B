using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    private Transform player;
    public float speed;
    public float health = 10;
    
    public int pointsForKill = 5;
    public GameObject particle;



    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
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

