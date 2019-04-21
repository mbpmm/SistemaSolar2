using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public List<Transform> target;
    public float timeLimit;
    public Vector3 offset;

    private Vector3 initialPos;
    private float changeTarget;
    private int aux;
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
        if (aux == target.Count)
        {
            aux = 0;
        }
    }
}
