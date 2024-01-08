using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody playerRb;
    public float speed = 5.0f;
    private float horizontal;
    private float vertical;
    private bool isOnGround;
    public float jumpForce = 6.0f;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Player position
        //horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        //Move player (Translation)
        transform.Translate(Vector3.forward * Time.deltaTime * speed * vertical);
        //transform.Translate(Vector3.right * Time.deltaTime * speed * horizontal);

        //Jump
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround == true)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
    }
}
