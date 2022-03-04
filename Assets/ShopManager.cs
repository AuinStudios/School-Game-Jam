using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    public GameObject previouspage;
    public GameObject nextpage;
    public GameObject powerups;
    public GameObject selectedSkin;
    public GameObject trails;
    public Text selectedText;
    private int coins;
    private int fuel;
    private int fprice;
    private int hp;
    private int hp_price;
    private int loss;

    public void OnNextBtnPressed()
    {
        previouspage.SetActive(false);
        nextpage.SetActive(true);
    }
    
    public void OnBackBtnPressed()
    {
        previouspage.SetActive(true);
        nextpage.SetActive(false);
    }

    public void OnBallonsBtnPressed(){
        previouspage.SetActive(true);
        selectedSkin.SetActive(true);
        powerups.SetActive(false);
        trails.SetActive(false);
        selectedText.text = "Selected Skin";
    }
    public void OnTrailsBtnpressed()
    {
        previouspage.SetActive(false);
        nextpage.SetActive(false);
        selectedSkin.SetActive(false);
        powerups.SetActive(false);
        trails.SetActive(true);
    }
    public void OnPowerUpsBtnPressed(){
        previouspage.SetActive(false);
        nextpage.SetActive(false);
        trails.SetActive(false);
        selectedSkin.SetActive(false);
        powerups.SetActive(true);
        selectedText.text = "Upgrades";
        if(PlayerPrefs.GetInt("Fuel")==0){
            PlayerPrefs.SetInt("Fuel",10);
            PlayerPrefs.SetInt("Fprice",10);
            PlayerPrefs.SetInt("Hp",10);
            PlayerPrefs.SetInt("Hp_price",10);
        }
    }

    public void OnFuelUpgradeBtnPressed(){
        fuel=PlayerPrefs.GetInt("Fuel");
        coins=PlayerPrefs.GetInt("Coins");
        fprice=PlayerPrefs.GetInt("Fprice");
        if(coins>=fprice){
            loss=fprice;
            fuel+=1;
            fprice+=10;
            coins-=loss;
            PlayerPrefs.SetInt("Fuel", fuel);
            PlayerPrefs.SetInt("Coins", coins);
            PlayerPrefs.SetInt("Fprice", fprice);
        }
    }

    public void OnHpUpgradeBtnPressed(){
        hp=PlayerPrefs.GetInt("Hp");
        coins=PlayerPrefs.GetInt("Coins");
        hp_price=PlayerPrefs.GetInt("Hp_price");
        if(coins>=hp_price){
            loss=hp_price;
            hp+=1;
            hp_price+=10;
            coins-=loss;
            PlayerPrefs.SetInt("Hp", hp);
            PlayerPrefs.SetInt("Coins", coins);
            PlayerPrefs.SetInt("Hp_price", hp_price);
        }
    }

    public void OnResetBtnPressed(){
        PlayerPrefs.SetInt("Fuel",10);
        PlayerPrefs.SetInt("Fprice",10);
        PlayerPrefs.SetInt("Hp",10);
        PlayerPrefs.SetInt("Hp_price",10);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
