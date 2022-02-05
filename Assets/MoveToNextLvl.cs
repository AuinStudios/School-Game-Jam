using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToNextLvl : MonoBehaviour
{
    public int NextSceneLoad;
    [SerializeField] private MenuManager coin;

    // Start is called before the first frame update
    void Start()
    {
        NextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    public void OnNextLvlBtnPressed()
    {
        SceneManager.LoadScene(NextSceneLoad);
        

        if(NextSceneLoad > PlayerPrefs.GetInt("LevlAt"))
        {
            PlayerPrefs.SetInt("LevelAt", NextSceneLoad);
        }
    }
   

}
