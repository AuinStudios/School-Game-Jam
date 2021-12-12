using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
  //  public Transform goaround;
    private Transform rot;
    private float idl;
    private Transform rotationCenter;

    private float rotationRadius = 5f;

    private float posX, posY, angle = 0f;

    // Update is called once per frame
   
   // Update is called once per frame
    public void Awake()
    {
         rotationCenter = this.transform.GetChild(2);
         rot = this.transform.GetChild(1);
    }
    public void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    void Update()
    {
        posX = rotationCenter.position.x + Mathf.Cos(angle) * rotationRadius;
        posY = rotationCenter.position.y + Mathf.Sin(angle) * rotationRadius;
        rot.position = new Vector2(posX, posY);
        angle = idl * 3 ;

        if (angle >= 360f)
        {
           angle = 0f;
        }
            
        gameObject.GetComponent<Rigidbody2D>().velocity =  Vector2.ClampMagnitude(gameObject.GetComponent<Rigidbody2D>().velocity, 5);
        idl += Input.GetAxis("Mouse Y") * Time.deltaTime;
        Quaternion test = Quaternion.LookRotation(rotationCenter.position - rot.position , rot.TransformDirection(Vector3.forward));
        rot.rotation = new Quaternion(0, 0, test.z, test.w);
        if (Input.GetKey(KeyCode.Mouse0))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(rot.right * 5);
        } 
    }
}
