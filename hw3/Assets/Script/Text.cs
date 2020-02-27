using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text : MonoBehaviour
{
    public static GameObject txt;
    // Start is called before the first frame update
    void Start()
    {
        txt = GameObject.Find("Text");
        txt.SetActive(false);    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
