using UnityEngine;

public class playerCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision objectHit)
    {
        if(objectHit.collider.tag == "obstacle") {
        Debug.Log("collided");
        }
    }
}
