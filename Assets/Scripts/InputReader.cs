using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputReader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SetUserName(string name)
    {
        PlayerPrefs.SetString("User", name);
    }
}
