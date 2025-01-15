using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Movement : MonoBehaviour
{
    public GameObject player;
    public float speed;
     
    [Header("Booleans")]
    private bool moveLeft;
    private bool moveRight;
    private bool moveUp;
    private bool moveDown;
    [Header("Key Bindings")]
    private KeyCode goLeft = KeyCode.A;
    private KeyCode goRight = KeyCode.D;
    private KeyCode goUp = KeyCode.W;
    private KeyCode goDown = KeyCode.S;
    private void PlayerInput()
    {
        moveLeft = Input.GetKey(goLeft);
        moveRight = Input.GetKey(goRight);
        moveUp = Input.GetKey(goUp);
        moveDown = Input.GetKey(goDown);
    }

    // Update is called once per frame
    void Update()
    {
        PlayerInput();

        if(moveLeft)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if(moveRight)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        if(moveUp)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        if(moveDown)
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
    }
}
