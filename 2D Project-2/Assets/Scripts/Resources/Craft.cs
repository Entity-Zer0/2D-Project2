using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Craft : MonoBehaviour
{
    public string itemName;

    public Player myPlayer;
    public int itemNumber = 1;

    public GameObject craft;

    public bool craftEnabled = false;

    // Start is called before the first frame update
    void Start()
    {
        myPlayer = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (myPlayer.myInvDict["Wood"] >= 5 && myPlayer.myInvDict["Stone"] >= 5 && myPlayer.myInvDict["Oil"] >= 3)
            {
                myPlayer.myInvDict["Wood"] -= 5;
                myPlayer.myInvDict["Stone"] -= 5;
                myPlayer.myInvDict["Oil"] -= 3;
                myPlayer.myInvDict.Add("Tower", 1);
            }
        }
    }
}
