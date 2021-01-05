using UnityEngine;
using System.Collections;

public class playerScript : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    float first_x, first_y, first_z;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        transform.Rotate(new Vector3(8.0f, 0.0f, 0.0f));

        first_x = this.transform.position.x;
        first_y = this.transform.position.y;
        first_z = this.transform.position.z;
    }

    void Update()
    {
        float speed = 8.5f;
        Transform myTransform = this.transform;
        Vector3 pos = myTransform.position;
        /*
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0.0f, 1.0f, 0.0f));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0.0f, -1.0f, 0.0f));
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(new Vector3(-1.0f, 0.0f, 0.0f));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(new Vector3(1.0f, 0.0f, 0.0f));
        }*/

        float x = 0.0f;
        float z = 0.0f;
        float y = 0.0f;

        if (Input.GetKey(KeyCode.Space))
        {
            pos.x = first_x;
            pos.y = first_y;
            pos.z = first_z;
            myTransform.position = pos;
        }
        if (Input.GetKey(KeyCode.D))
        {
            x += speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            x -= speed;
        }
        if (Input.GetKey(KeyCode.W))
        {
            z += speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            z -= speed;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
                y += speed;
        }
        if (!(this.transform.position.y < 1.0f))
        {
            if (Input.GetKey(KeyCode.DownArrow))
            {
                y -= speed;
            }
        }

        m_Rigidbody.velocity = new Vector3(x, y, z);
    }
}