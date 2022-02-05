using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdSpawner : MonoBehaviour
{
    public GameObject bird;

    public float maxTime;
    float timer;

    public float maxY;
    public float minY;
    float randY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         timer += Time.deltaTime;
         if(timer >= maxTime)
         {
            InstantiateBird();
            timer = 0;
         }
    }

    public void InstantiateBird()
    {
        randY = Random.Range(minY,maxY);
         GameObject newbird = Instantiate(bird);
         newbird.transform.position = new Vector2(
            transform.position.x,
            randY);
    }


}
