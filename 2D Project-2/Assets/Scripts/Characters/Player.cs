using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public GameObject player;
    public float speed = 0.5f;
    // public int wood = 0;
    // public int stone = 0;
    // public int oil = 0;

    public Dictionary<string, int> myInvDict = new Dictionary<string, int>();

    public TextMeshProUGUI inventoryDisplay;

    public GameObject tower;


    // Start is called before the first frame update
    public void Awake()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        //myInvDict.Add("Wand", 1);
        DisplayInventory();

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPos = new Vector3 (-46, -16, 0);

        if (Input.GetKey(KeyCode.W))
        {
            player.transform.position += Vector3.up * speed;
            //Debug.Log("W Pressed");
        }

        if (Input.GetKey(KeyCode.A))
        {
            player.transform.position += Vector3.left * speed;
            //Debug.Log("A Pressed");
        }

        if (Input.GetKey(KeyCode.S))
        {
            player.transform.position += Vector3.down * speed;
            //Debug.Log("S Pressed");
        }

        if (Input.GetKey(KeyCode.D))
        {
            player.transform.position += Vector3.right * speed;
            //Debug.Log("D Pressed");
        }

        if (Input.GetKey(KeyCode.C))
        {
            if (myInvDict["Tower"] >= 1)
            {
                Instantiate(tower, targetPos, Quaternion.identity);
                myInvDict["Tower"] -= 1;
            }
            
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        /*if (collision.gameObject.tag == "Key")
        {
            Destroy(collision.gameObject);
        }*/

        if (collision.gameObject.tag == "Death")
        {
            Destroy(player);
        }
    }

    void OnTriggerStay2D (Collider2D other)
    {
        if (other.gameObject.tag == "Craft" && Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Enter craft");
            if (myInvDict["Wood"] >= 5 && myInvDict["Stone"] >= 5 && myInvDict["Oil"] >= 3)
            {
                Debug.Log("Flint and steal");
                myInvDict["Wood"] -= 5;
                myInvDict["Stone"] -= 5;
                myInvDict["Oil"] -= 3;
                myInvDict.Add("Tower", 1);
            }
        }
    }


    public void DisplayInventory()
    {
        inventoryDisplay.text = "Inventory\n\n";
        foreach (var item in myInvDict)
        {
            inventoryDisplay.text += " " + item.Key + ": " + item.Value + "\n";
        }
    }
}