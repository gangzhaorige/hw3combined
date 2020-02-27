using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UI2 : MonoBehaviour
{
  
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
       
    }

     void OnGUI(){
        if(GUI.Button(new Rect(10, 10, 220, 30), " Click Me to return to Scene1"))
        {
            SceneManager.LoadScene("Scene1");
        }

   
    }
}
