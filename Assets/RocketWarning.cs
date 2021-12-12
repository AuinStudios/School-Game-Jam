using System.Collections;
using UnityEngine;

public class RocketWarning : MonoBehaviour
{
    public GameObject warning;
     private int i;
    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(spawn());
    }

    public IEnumerator spawn()
    {

       i = 0;
        Camera.main.transform.GetChild(0).gameObject.SetActive(true);
        GameObject.Find("warning").transform.position = new Vector2(GameObject.Find("warning").transform.position.x, Random.Range(-4, 4));

        while(i < 30)
        {

            Vector2 scale = new Vector2(0.2909483f, 0.2909483f);
            Vector2 oldscale = new Vector2(0.25567f, 0.25567f);
            if (GameObject.Find("warning").GetComponent<Transform>().localScale.x >= 0.2809483f)
            {
                GameObject.Find("warning").GetComponent<SpriteRenderer>().color = Color.Lerp(GameObject.Find("warning").GetComponent<SpriteRenderer>().color, Color.white, 10f * Time.fixedDeltaTime);

                GameObject.Find("warning").GetComponent<Transform>().localScale = Vector2.Lerp(GameObject.Find("warning").GetComponent<Transform>().localScale, oldscale, 15f  * Time.fixedDeltaTime);
            }
            else 
            {
                GameObject.Find("warning").GetComponent<SpriteRenderer>().color = Color.Lerp(GameObject.Find("warning").GetComponent<SpriteRenderer>().color, Color.red, 10f * Time.fixedDeltaTime);


                 GameObject.Find("warning").GetComponent<Transform>().localScale = Vector2.Lerp(GameObject.Find("warning").GetComponent<Transform>().localScale, scale, 15f * Time.fixedDeltaTime);
            }
             
            yield return new WaitForSeconds(0.1f);
           i++;
        }
       
       Vector2 pos = new Vector2(GameObject.Find("warning").transform.position.x + 10, GameObject.Find("warning").transform.position.y);
         GameObject.Find("warning").gameObject.SetActive(false);
      Instantiate(warning, pos, warning.transform.rotation );
        while(i < 35)
        {
            Vector2 speed = new Vector2(-30, 0);
            GameObject.FindGameObjectWithTag("Rocket").GetComponent<Rigidbody2D>().velocity = speed;
            yield return new WaitForSeconds(0.4f);
            i++;
        }
       Destroy( GameObject.FindGameObjectWithTag("Rocket"));
    }
}
