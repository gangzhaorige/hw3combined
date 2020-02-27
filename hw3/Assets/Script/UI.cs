using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;


public class UI : MonoBehaviour
{
    private Texture2D texture;
    private string serialNumber;
    public static GameObject obj;
    private int number = 1;
  

    //Changing the texture of the cube.
    void OnGUI(){
        if(GUI.Button(new Rect(10, 10, 220, 30), " b. Click Me to Change texture"))
        {
          if(number == 2)
            number--;
          else
              number++;
        
         serialNumber = Convert.ToString(number);
         texture = (Texture2D)Resources.Load(serialNumber);
         obj = GameObject.Find("TextureCube");
         obj.GetComponent<Renderer>().material.mainTexture = texture;  
        }      
        
        if(GUI.Button(new Rect(250, 10, 220, 30), " e. Click Me to Change the scene"))
        {
            SceneManager.LoadScene("Scene2");
        }
   
    }
}
