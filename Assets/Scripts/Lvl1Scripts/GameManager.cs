using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public  static Vector2 bottomLeft;
    public GameObject gameoverpanel;
    public PlayerHealth playerhealth;
    public GameObject Youwin;
    public GameObject pausedpanel;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }
    public void onreplaybtnpressed()
    {
        
        SceneManager.LoadScene("lvl1");
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

    public void OnReplayBtn1pressed()
    {
        SceneManager.LoadScene("tuto"); 
        gameoverpanel.SetActive(false);
    }

    public void OnReplayBtn2pressed()
    {
        SceneManager.LoadScene("lvl2");
		gameoverpanel.SetActive(false);
    }
	
	public void OnReplayBtn3pressed()
	{
		SceneManager.LoadScene("lvl3");
		gameoverpanel.SetActive(false);
	}

    // Update is called once per frame
    void Update()
    {
        if( playerhealth.currentHealth <= 0)
        {
            Time.timeScale = 0;
            gameoverpanel.SetActive(true);
        }
    }
    public void OnNextLvl1btnpressed()
    {
        SceneManager.LoadScene("lvl1");
        Youwin.SetActive(false);
    }
    public void OnNextLvl2BtnPressed()
    {
        SceneManager.LoadScene("lvl2");
        Youwin.SetActive(false);
    }
    public void OnNextLvl3btnpressed()
    {
        SceneManager.LoadScene("lvl3");
        Youwin.SetActive(false);
    }

    public void OnReplay4Btnpressed()
    {
        SceneManager.LoadScene("lvl4");
        gameoverpanel.SetActive(false);
    }

    public void OnReplay5BtnPressed()
    {
        SceneManager.LoadScene("lvl5");
        gameoverpanel.SetActive(false);
    }

    public void OnResumeBtnPressed()
    {
        pausedpanel.SetActive(false);
        Time.timeScale = 1;
    }
    
    public void Onreplay6btnpressed()
    {
    SceneManager.LoadScene("lvl6");
    gameoverpanel.SetActive(false);
    }

    public void OnReplay7btnpressed()
    {
        SceneManager.LoadScene("lvl7");
        gameoverpanel.SetActive(false);
    }
    
}
