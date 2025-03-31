using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Towers : CharacterBase
{
    public GameObject projectile;
    public float spawnTimer = 0f;
    public float spawnInterval = 0.5f;

    private void Update()
    {
        spawnTimer += Time.deltaTime;
        if (spawnTimer >= spawnInterval)
        {
            Instantiate(projectile, transform.position, Quaternion.identity);
            spawnTimer = 0f;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("colliding with enemy");
            health = health - 10;
            Destroy(collision.gameObject);
        }
    }

}
