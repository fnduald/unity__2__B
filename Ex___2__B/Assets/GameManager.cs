using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GameManager : MonoBehaviour
{

    
    public GameData gamedata;

    void Start()
    {
       print("Game Name : " + gamedata.gameName);
       print("Game Score : " + gamedata.gameScore);
       print(" Is Game Active  : " + gamedata.isGameActive);

    }


}
