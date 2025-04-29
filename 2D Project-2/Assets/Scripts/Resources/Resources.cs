using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resources : MonoBehaviour
{
    public string itemName;

    public Player myPlayer;
    public int itemNumber = 1;

    public GameObject pickUp;

    public bool pickUpEnabled = false;

    // Start is called before the first frame update
    void Start()
    {
        myPlayer = FindObjectOfType<Player>();
        pickUp.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (pickUpEnabled == true && Input.GetKeyDown(KeyCode.Space))
        {
            AddItem();
        }
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        pickUp.SetActive(true);
        pickUpEnabled = true;
       /* if (Input.GetKeyDown(KeyCode.Space))
        {
            AddItem();
        }*/
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        pickUp.SetActive(false);
        pickUpEnabled = false;
    }
    public void AddItem()
    {
        if (myPlayer.myInvDict.ContainsKey(itemName))
        {
            myPlayer.myInvDict[itemName] += itemNumber;
        }
        else
        {
            myPlayer.myInvDict.Add(itemName, itemNumber);
        }
        myPlayer.DisplayInventory();

    }
}
