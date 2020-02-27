using UnityEngine;

public class RedCube : MonoBehaviour
{
   public Rigidbody cube;
   public float moveForce = 10f;

    // Update is called once per frame
    void FixedUpdate()
    {

        if( Input.GetKey("a"))
        {
            cube.AddForce(-moveForce, 0, 0);
        }
        if( Input.GetKey("d"))
        {
            cube.AddForce(moveForce, 0, 0);
        }
        if( Input.GetKey("w"))
        {
            cube.AddForce(0, 0, moveForce);
        }
        if( Input.GetKey("s"))
        {
            cube.AddForce(0, 0, -moveForce);
        }
    }

     void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "wall")
        {
            Text.txt.SetActive(true);
        }
    }

     void OnCollisionExit(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "wall")
        {
            Text.txt.SetActive(false);
        }
    }
}
