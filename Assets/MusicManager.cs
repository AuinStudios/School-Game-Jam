using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    [SerializeField] AudioSource music;
   
    // Start is called before the first frame update
    void Start()
    {
       music.Play();
    }

    // Update is called once per frame
    void Update()
    {
      Scene currentScene = SceneManager. GetActiveScene();
      if (currentScene.name != "StartScene")
      {
          music.Stop();
      }
      
      
    }
}
