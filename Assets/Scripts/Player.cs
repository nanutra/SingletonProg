using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Rigidbody m_rigidbody;
    private Vector3 m_force;
    
    [SerializeField, Tooltip("speed of the char"), Range(0, 20)] private int m_speed = 10;
    [SerializeField, Tooltip("rotation speed"), Range(0, 200)] private int m_rotationSpeed = 100;
    
    private int m_score = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        TestSingleton.m_instance.ChangeScore();
    }

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical")* m_speed * Time.deltaTime;
        float rotation = Input.GetAxis("Horizontal") * m_rotationSpeed * Time.deltaTime;

        m_force = new Vector3(0, 0, translation);
        m_rigidbody.AddForce(m_force);
        transform.Rotate(0,rotation,0);
    }
}
