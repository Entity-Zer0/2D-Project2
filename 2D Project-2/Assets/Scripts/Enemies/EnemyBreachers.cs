using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBreachers : CharacterBase 
{
    public GameObject targetTower;
    public GameObject thisObject;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        targetTower = GameObject.FindWithTag("Tower");
    }

    // Update is called once per frame
    void Update()
    {
        DisplayHealth();
        Health();
        //Display
        //manager = FindObjectOfType<GameManager>();
        thisObject.transform.position += VectorToTower() * speed;
    }

    Vector3 VectorToTower()
    {
        Vector3 targetDirection;
        targetDirection = targetTower.transform.position - transform.position;
        targetDirection = targetDirection.normalized;
        return targetDirection; 
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Projectile")
        {
            health = health - 10;
            Destroy(other.gameObject);
        }
    }

    public override void Health()
    {
        if (health <= 0)
        {
            //gameManager.enemyCounter--;
            Destroy(gameObject);
        }
    }
}
