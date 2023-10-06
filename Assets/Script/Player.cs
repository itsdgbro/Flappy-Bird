using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Player
public class Player : MonoBehaviour
{   
    private Rigidbody2D rb;
    [SerializeField]private float jumpForce = 10f;
    [SerializeField]private float rotationSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transform.position = new Vector3(-5,3,0);   
    }

    // Update is called once per frame
    void Update()
    {       
        if(Input.GetKeyDown(KeyCode.Space)){
            rb.velocity = Vector2.up * jumpForce;
        }
    }

    void FixedUpdate(){
        transform.rotation = Quaternion.Euler(0, 0, rb.velocity.y * rotationSpeed);
    }

    private void OnCollisionEnter2D(Collision2D collision){
        Debug.Log("Collide");
        GameManager.instance.GameOver();
    }
}
