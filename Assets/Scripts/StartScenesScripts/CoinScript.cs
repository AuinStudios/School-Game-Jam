using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScript : MonoBehaviour
{
  [SerializeField] private Text scoreText;
  private int coins;

  void Start()
  {
    coins = PlayerPrefs.GetInt("Coins");
    PlayerPrefs.SetInt("Coins", coins);
  } 

  void Update() => scoreText.text = "" + coins;

  public void AddCoins() => coins += 5;
}
