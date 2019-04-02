using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{

    CharacterInput character_input;
    Rigidbody mybody; 

    public float Speed;


















    // Start is called before the first frame update
    void Start()
    {
        character_input = GetComponent<CharacterInput>();
        mybody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(horizontal, 0f, vertical) * Speed * Time.deltaTime;
        transform.Translate(moveDirection);

    }
}
