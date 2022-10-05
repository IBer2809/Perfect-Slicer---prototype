using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.TryGetComponent(out Food food))
        {
            Debug.Log("yes");
            Destroy(food.gameObject);
        }
    }
}
