﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillCode : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Banana")
        {
            Destroy(collision.gameObject);
            Destroy(GameObject.Find("Monkey"));
        }
    }
}
