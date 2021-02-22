using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 


public class Controler : MonoBehaviour
{
    public string playerName2;
    public Text tellPlayer;
    public GameObject Spearmen;
    public GameObject Swordmen;
    public GameObject Crossbow;
    public GameObject Hammer;


    // Start is called before the first frame update
    void Awake()
    {
        playerName2 = PlayerPrefs.GetString("ThisPlayer", "playerName");
        tellPlayer.text = playerName2 +"'s" +  " Fighter!";
    }

    public void changeSpear()
    {
        Spearmen.SetActive(true);
        Swordmen.SetActive(false);
        Crossbow.SetActive(false);
        Hammer.SetActive(false);
    }

    public void changeSword()
    {
        Spearmen.SetActive(false);
        Swordmen.SetActive(true);
        Crossbow.SetActive(false);
        Hammer.SetActive(false);
    }

    public void changeCrossbow()
    {
        Spearmen.SetActive(false);
        Swordmen.SetActive(false);
        Crossbow.SetActive(true);
        Hammer.SetActive(false);
    }

    public void changeHammer()
    {
        Spearmen.SetActive(false);
        Swordmen.SetActive(false);
        Crossbow.SetActive(false);
        Hammer.SetActive(true);
    }
}
