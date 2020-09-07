using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : MonoBehaviour
{
    public void Kuning () 
    {
        GetComponent<Renderer>().material.color = Color.yellow;
    }
    public void Hijau () 
    {
        GetComponent<Renderer>().material.color = Color.green;
    }
    public void Putih () 
    {
        GetComponent<Renderer>().material.color = Color.white;
    }
}
