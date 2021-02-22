using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerName : MonoBehaviour
{
    public InputField battlenameInput;
    public string battleName;

    // Setting the name of the player.
    public void SetName()
    {
        battleName = battlenameInput.text;
        Debug.Log("The fighters name is " + battleName);
    }
    public void GameStart()
    {
        PlayerPrefs.SetString("ThisPlayer", battleName);
        SceneManager.LoadScene("CharacterPick");
    }
}
