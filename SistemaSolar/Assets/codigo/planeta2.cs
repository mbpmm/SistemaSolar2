using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planeta2 : MonoBehaviour
{
    public string nombre;
    public float speed;
    public float radio;
    public float angulo;
    public float rotationSpeed;
    public Material mat;
    public Transform prefab;
    public Camara cam;
    // Start is called before the first frame update
    void Start()
    {
        angulo = 0;
        radio = transform.position.y;
        Debug.Log("Nombre: " + nombre);
        for (int i = 0; i < 8; i++)
        {
            Transform t = Instantiate(prefab, new Vector3(0,i * -20.0f-70, 0), Quaternion.identity);
            t.transform.localScale = new Vector3(0.5f * i + 1, 0.5f * i + 1, 0.5f * i + 1);
            t.GetComponent<MeshRenderer>().material = mat;
            cam.GetComponent<Camara>().target.Add(t);
        }
    }

    // Update is called once per frame
    void Update()
    {
        angulo += speed * Time.deltaTime;
        transform.position = new Vector3(0, radio * Mathf.Cos(angulo), radio * Mathf.Sin(angulo));
        transform.Rotate(new Vector3(rotationSpeed, 0, 0), rotationSpeed, Space.Self);
    }
}
