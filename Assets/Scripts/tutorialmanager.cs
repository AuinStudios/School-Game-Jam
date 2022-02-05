using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialmanager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
    }

    public void OnEnterBtnPressed()
    {
        Time.timeScale = 1;
    }
}
