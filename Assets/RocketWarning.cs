using System.Collections;
using UnityEngine;

public class RocketWarning : MonoBehaviour
{
    public GameObject JetPrefab;
    private GameObject warning;
    private SpriteRenderer colorRender;
    private float TimeUntllAnother = 0;
    private PlayerHealth health;
    // Start is called before the first frame update
    private void Start()
    {
        health = gameObject.GetComponent<PlayerHealth>();
        warning = GameObject.Find("warning");
        colorRender = warning.GetComponent<SpriteRenderer>();
        warning.SetActive(false);
    }
    private void Update()
    {
        if(TimeUntllAnother <= 30f)
        {
            TimeUntllAnother += 3 * Time.deltaTime;
        }
        else
        {
            StartCoroutine(spawn());
            TimeUntllAnother = 0;
        }
    }
    private IEnumerator spawn()
    {
        warning.SetActive(true);
        WaitForSeconds waitspawn = new WaitForSeconds(0.1f);
       int i = 0;
       // warning.SetActive(true);
        warning.transform.position = new Vector2(warning.transform.position.x, Random.Range(-4, 4));
        while (i < 30)
        {

            Vector2 scale = new Vector2(0.2909483f, 0.2909483f);
            Vector2 oldscale = new Vector2(0.25567f, 0.25567f);
            if (warning.transform.localScale.x >= 0.2809483f)
            {
                colorRender.color = Color.Lerp(colorRender.color, Color.white, 10f * Time.fixedDeltaTime);

                warning.transform.localScale = Vector2.Lerp(warning.transform.localScale, oldscale, 15f * Time.fixedDeltaTime);
            }
            else
            {
                colorRender.color = Color.Lerp(colorRender.color, Color.red, 10f * Time.fixedDeltaTime);



                warning.transform.localScale = Vector2.Lerp(warning.transform.localScale, scale, 15f * Time.fixedDeltaTime);
            }

            yield return waitspawn;
            i++;
        }
        WaitForSeconds wait = new WaitForSeconds(0.4f);
        Vector2 pos = new Vector2(warning.transform.position.x + 10, warning.transform.position.y);
        warning.gameObject.SetActive(false);
        Instantiate(JetPrefab, pos, JetPrefab.transform.rotation);
        GameObject jet = GameObject.FindGameObjectWithTag("Rocket");
        Rigidbody2D rigijet = jet.GetComponent<Rigidbody2D>();
        jet.GetComponent<birdDamage>().playerhealth = health;
        Vector2 speed = new Vector2(-30, 0);
        while (i < 50)
        {
            rigijet.velocity = speed;
            yield return wait;
            i++;
        }
        Destroy(jet);
    }
}
