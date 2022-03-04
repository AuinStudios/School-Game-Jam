using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class next1lvl : MonoBehaviour
{
    [SerializeField] private MenuManager coin;
    //public GameObject Youwin;
    public GameObject balloon;

    public void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            balloon.SetActive(false);
            coin.AddCoins();
            //Destroy(col.gameObject);
            //SceneManager.LoadScene("lvl1");
            //Youwin.SetActive(true);
            //coinscript.AddCoins();

        }
    }
}
