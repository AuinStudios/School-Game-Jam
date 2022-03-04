using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneSin : MonoBehaviour
{
	float sinCenterY;
	public float amplitude = 2;
	public float frequency = 1;
    // Start is called before the first frame update
    void Start()
    {
        sinCenterY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	public void FixedUpdate(){
		Vector2 pos = transform.position;
		float sin = Mathf.Sin(pos.x * frequency) * amplitude;
		pos.y = sinCenterY + sin;
		transform.position = pos;
	}
}
