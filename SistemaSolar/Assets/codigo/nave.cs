using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nave : MonoBehaviour
{
    public float velocidad;
    public float force;
    private Rigidbody rig;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        //transform.position = new Vector3(transform.position.x + horizontal * velocidad * Time.deltaTime, transform.position.y + vertical * velocidad * Time.deltaTime, 0);

        Vector3 dir = new Vector3(0, vertical, -1*horizontal);
        rig.AddForce(dir * force);
    }
}
