using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public Transform[] target;
    float changeTarget;
    public float timeLimit;
    Vector3 initialPos;
    public Vector3 offset;
    int aux;
    // Start is called before the first frame update
    void Start()
    {
        initialPos = transform.position;
        changeTarget = 0;
        aux = 0;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        changeTarget += Time.deltaTime;
        transform.position = target[aux].position + offset;
        if (changeTarget > timeLimit)
        {
            changeTarget = 0;
            aux++;
        }
        if (aux==target.Length)
        {
            aux = 0;
        }
    }
}
