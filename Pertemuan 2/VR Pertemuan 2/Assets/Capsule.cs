using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : MonoBehaviour
{
    public void Magenta () 
    {
        GetComponent<Renderer>().material.color = Color.magenta;
    }
    public void Abu () 
    {
        GetComponent<Renderer>().material.color = Color.grey;
    }
    public void biruTua () 
    {
        GetComponent<Renderer>().material.color = Color.cyan;
    }
}
