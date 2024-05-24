using Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterInputController : MonoBehaviour
{
    private PlayerModel PlayerModel;
    private CharacterMovementController characterMovementController;

    private void Start()
    {
        PlayerModel = GetComponent<PlayerModel>();
        characterMovementController = PlayerModel.Entity.gameObject.GetComponent<CharacterMovementController>();
    }
    public void OnMove(InputAction.CallbackContext context) 
    {
        Vector2 movement = context.ReadValue<Vector2>();

        if(characterMovementController != null ) { }

        characterMovementController.Movement(movement);
    }
         
}
