using UnityEngine;


public class CameraSetting : MonoBehaviour
{
    public Transform redCube;
    public Transform ground;
    public Vector3 followPostion;
    public Vector3 followRotation;
    public Vector3 topdownRotation;
    public Vector3 topdownPostition;   
    public bool view = false;
    void Update()
    {
        if(Input.GetKey("t"))
            view = true;
        if(Input.GetKey("f"))
            view = false;

        if(view){
            transform.position = ground.position + topdownPostition;
            transform.eulerAngles = topdownRotation;   
        }
        else{
            view = false;
            transform.position = redCube.position + followPostion;
            transform.eulerAngles = followRotation;     
         }    
    }
 }
