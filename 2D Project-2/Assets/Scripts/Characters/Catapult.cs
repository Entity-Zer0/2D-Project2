using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catapult : CharacterBase
{
    public GameObject projectile;
    public float spawnTimer = 0f;
    public float spawnInterval = 2.0f;

    private void Update()
    {
        DisplayHealth();
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
