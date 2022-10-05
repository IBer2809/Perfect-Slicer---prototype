using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private float _spawnDelay;
    [SerializeField] private GameObject[] _templates;


    private void Start()
    {
        StartCoroutine(SpawnFood());
    }
    private IEnumerator SpawnFood()
    {
        while (true)
        {
            int foodIndex = Random.Range(0, _templates.Length);
            Instantiate(_templates[foodIndex], transform.position, _templates[foodIndex].transform.rotation);
            yield return new WaitForSeconds(_spawnDelay);
        }
        
    }
}
