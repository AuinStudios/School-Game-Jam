using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MenuManager : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    private int coins;
    public GameObject Panel;
    public GameObject InfoPanel;
    public GameObject gamePanel,infopanel;
    public MoveToNextLvl MoveToNextLvl;
    public Coin coin;

    // Start is called before the first frame update
    void Start()
    {
        coins = PlayerPrefs.GetInt("Coins");
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "" + coins;
        if(Input.GetKey("c"))
            PlayerPrefs.DeleteAll();
    }

    public void AddCoins()
    {
        coins += 150;
    }

    public void addcoinscoinsprite()
    {
        coins+=5;
    }

    public void OnLevel1btnPressed()
    {
        PlayerPrefs.SetInt("Coins", coins);
        SceneManager.LoadScene("lvl1");
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

    public void OnTutobtnpressed()
    {
        SceneManager.LoadScene("tuto");
    }

    public void OnLvl2btnpressed()
    {
        SceneManager.LoadScene("lvl2");
    }
	
	public void OnLvl3btnpressed()
	{
		SceneManager.LoadScene("lvl3");
	}	

    public void nextbtnpressed()
    {
        gamePanel.SetActive(true);
        InfoPanel.SetActive(false);
    }
    public void OnArrowBackBtnPressed()
    {
        gamePanel.SetActive(false);
        InfoPanel.SetActive(true);
    }

    public void OnShopBtnPressed()
    {
        PlayerPrefs.SetInt("Coins", coins);
        SceneManager.LoadScene("ShopScene");
    }

    public void OnNextLvlBtnPressed()
    {
        MoveToNextLvl.OnNextLvlBtnPressed();
        PlayerPrefs.SetInt("Coins", coins);
    }

    public void collidercoin()
    {
        PlayerPrefs.SetInt("Coins", coins);
    }


}
