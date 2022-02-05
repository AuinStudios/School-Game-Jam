using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LvlSelection : MonoBehaviour
{
    public Button[] lvlbtns;
    // Start is called before the first frame update
    void Start()
    {
        int LevelAt = PlayerPrefs.GetInt("LevelAt", 1);

        for(int i = 0; i<lvlbtns.Length; i++)
        {
            if(i + 1 > LevelAt)
                lvlbtns[i].interactable = false;
        }
    }

   
}
