using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rigid;
    public float jumpPower;
    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Vector3 vec = new Vector3(0, jumpPower, 0);
            rigid.AddForce(vec, ForceMode.Impulse);
        }
    }
}
