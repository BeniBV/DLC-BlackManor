﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{

    Vector2 mouselook;
    public float sensitivity;
    GameObject character;
    // Start is called before the first frame update
    void Start()
    {
        character = this.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Mouse X");
        float vertical = Input.GetAxis("Mouse Y");

        Vector2 look = new Vector2(horizontal, vertical);
        mouselook += look * sensitivity;

        mouselook.y = Mathf.Clamp(mouselook.y, -80f, 80);

        transform.localRotation = Quaternion.AngleAxis(-mouselook.y, Vector3.right);
        character.transform.localRotation = Quaternion.AngleAxis(mouselook.x, character.transform.up);
    }
}
