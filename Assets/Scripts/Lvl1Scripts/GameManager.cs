using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public  static Vector2 bottomLeft;
    public GameObject gameoverpanel;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }
    public void onreplaybtnpressed()
    {
        
        SceneManager.LoadScene("lvl1scene");
        gameoverpanel.SetActive(false);
        
    }
    private void Awake()
    {
         bottomLeft = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
    }

    public void OnMenubtnpressed()
    {
        SceneManager.LoadScene("StartScene");
        gameoverpanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
