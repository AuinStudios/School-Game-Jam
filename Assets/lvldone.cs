using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.SceneManagement;

public class lvldone : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            Destroy(col.gameObject);
            SceneManager.LoadScene("StartScene");

        }
    }

}
