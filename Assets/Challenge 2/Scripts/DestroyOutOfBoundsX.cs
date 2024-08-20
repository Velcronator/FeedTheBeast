using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float topLimit = 30;
    private float bottomLimit = -5;
    [SerializeField] private float leftLimit = -10;
    [SerializeField] private float rightLimit = 10;


    void Update()
    {
        // Destroy dogs if x position less than left limit
        if (transform.position.y > topLimit)
        {
            Destroy(gameObject);
        } 
        // Destroy balls if y position is less than bottomLimit
        else if (transform.position.y < bottomLimit)
        {
            Destroy(gameObject);
        }
        // Destroy Dogs if x position is less than leftLimit
        else if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x > rightLimit)
        {
            Destroy(gameObject);
        }

    }
}
