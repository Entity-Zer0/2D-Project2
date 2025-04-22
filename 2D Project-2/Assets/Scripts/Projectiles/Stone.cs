using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : BaseProjectile
{

    // Start is called before the first frame update
    void Start()
    {
        xDir = Random.Range(-1f, 1f);
        yDir = Random.Range(-1f, 1f);

        targetEnemy = GameObject.FindWithTag("Enemy");
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        //thisObject.transform.position += new Vector3(xDir, yDir, 0) * speed;
        if (timer >= lifeTime)
        {
            Destroy(gameObject);
        }

        thisObject.transform.position += VectorToEnemy() * speed;
    }
    Vector3 VectorToEnemy()
    {
        Vector3 targetDirection;
        targetDirection = targetEnemy.transform.position - transform.position;
        targetDirection = targetDirection.normalized;
        return targetDirection;
    }
}
