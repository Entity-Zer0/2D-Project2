using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resources : MonoBehaviour
{
    public string itemName;
    public int objectIndex;

    public Player myPlayer;
    public int itemNumber = 1;

    public GameObject pickUp;

    // Start is called before the first frame update
    void Start()
    {
        myPlayer = FindObjectOfType<Player>();
        pickUp.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerStay2D(Collider2D other)
    {
        pickUp.SetActive(true);
        if (Input.GetKey(KeyCode.Space))
        {
            AddItem();
        }
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
