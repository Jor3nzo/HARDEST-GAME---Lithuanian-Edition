using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public string nextlevelName;
    public Vector3 spawnPoint;
    public float speed = 0.01f;


    // Start is called before the first frame update
    void Start()
    {
        spawnPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 movementDirection = new Vector3();
        movementDirection.x = Input.GetAxisRaw("Horizontal");
        movementDirection.z = Input.GetAxisRaw("Vertical");

        //transform.position += movementDirection * speed * Time.deltaTime;
        GetComponent<Rigidbody>().velocity = movementDirection * speed;
        transform.forward = movementDirection;



        //if (Input.GetKey(KeyCode.D))
        //{
        //    transform.Translate(speed * Time.deltaTime, 0, 0);
        //}

        //if (Input.GetKey(KeyCode.A))
        //{
        //    transform.Translate(-speed * Time.deltaTime, 0, 0);
        //}

        //if (Input.GetKey(KeyCode.W))
        //{
        //    transform.Translate(0, 0, speed * Time.deltaTime);
        //}

        //if (Input.GetKey(KeyCode.S))
        //{
        //    transform.Translate(0, 0, -speed * Time.deltaTime);
        //}

    }

    public void Die()
    {
        
        SceneManager.LoadScene("OldMemories");
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name.Contains("Enemy"))
        {
            Die();
        }
    }
}
