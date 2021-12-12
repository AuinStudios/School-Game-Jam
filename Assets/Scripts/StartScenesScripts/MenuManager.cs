using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MenuManager : MonoBehaviour
{

    public GameObject Panel;
    public GameObject InfoPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnLevel1btnPressed()
    {
       SceneManager.LoadScene("lvl1scene");
    }

    public void Onlvlsbtnpressed()
    {
        Panel.SetActive(true);
    }

    public void OnBackBtnPressed()
    {
        Panel.SetActive(false);
        InfoPanel.SetActive(false);
    }

    public void OnInfoBtnPressed()
    {
        InfoPanel.SetActive(true);
    }
}
