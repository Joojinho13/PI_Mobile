using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterController : MonoBehaviour
{

    private Rigidbody2D playerRigidbody;
    public float jetpackForce = 75.0f;
    public PlayerInput PlayerControls;
    public bool Pulo;

    void Awake()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        if(Pulo == true)
        {
            playerRigidbody.AddForce(new Vector2(0, jetpackForce));
        }
    }

    public void OnMouseClick(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            Pulo = true;
            Debug.Log("Botão Pressionado");
        }
        if(context.canceled)
        {
            Pulo = false;
            Debug.Log("Botão Liberado");
        }
    }
}
