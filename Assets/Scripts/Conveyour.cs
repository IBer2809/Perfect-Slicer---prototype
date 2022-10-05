using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conveyour : MonoBehaviour
{
    [SerializeField] private Transform _endPoint;
    [SerializeField] private float _moveSpeed;

    private void OnTriggerStay(Collider other)
    {
        other.transform.position = Vector3.MoveTowards(other.transform.position, _endPoint.position, _moveSpeed * Time.deltaTime);
        if(other.transform.position == _endPoint.position)
        {
            Destroy(other);
        }
    }
}
