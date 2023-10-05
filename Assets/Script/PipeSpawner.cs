using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField]private float maxTime = 5f;
    [SerializeField]private GameObject _pipe;

    private float timer;

    private void Start(){
        SpawnPipe();
    }

    private void Update()
{
    timer += Time.deltaTime;

    while (timer > maxTime)
    {
        SpawnPipe();
        timer -= maxTime; // Subtract maxTime from timer
    }
}


    private void SpawnPipe(){
        Vector3 spwanPos = transform.position + new Vector3(0,  Random.Range(-0.41f, 4.46f));
        GameObject pipe = Instantiate(_pipe, spwanPos, Quaternion.identity);

        Destroy(pipe, 5f);
    }   
}
