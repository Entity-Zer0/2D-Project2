using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CharacterBase : MonoBehaviour
{
    public string characterName;
    public int health;
    public TextMeshProUGUI displayHealth;
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }
    // Update is called once per frame
    void Update()
    {
        DisplayHealth();
        Health();
    }

    public virtual void Health()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
    public void DisplayHealth()
    {
        displayHealth.text = "Health: " + health;
    }
}
