using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float MovementForce;
    [HideInInspector] public float movX;
    [HideInInspector] public float movZ;
    private Rigidbody rb;
    public Text ScoreText;
    public GameObject WinPanel;
    public int puntos = 0;
    public Spawner spawner;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movX = movementVector.x;
        movZ = movementVector.y;
    }

    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(movX, 0.0f, movZ);
        rb.AddForce(movement * MovementForce);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Gold"))
        {
            other.gameObject.SetActive(false);
            puntos++;
            ScoreText.text = "Score: " + puntos.ToString();
            if (puntos == spawner.Objetivo)
            {
                WinPanel.SetActive(true);
            }
        }
    }




}
