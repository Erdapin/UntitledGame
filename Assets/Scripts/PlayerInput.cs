using System;
using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class PlayerInput : MonoBehaviour
{
    PlayerActions playerActions;

    public event EventHandler OnInteractAction;

    private void Awake()
    {
        playerActions = new PlayerActions();
        playerActions.PlayerActionss.Enable();
        playerActions.PlayerActionss.interact.performed += Interact_performed;
    }

    private void Interact_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        OnInteractAction?.Invoke(this, EventArgs.Empty);
    }

    public Vector2 GetMovementDirectionVectorNormalized()
    {
        Vector2 direction = Vector2.zero ;
        direction = playerActions.PlayerActionss.movement.ReadValue<Vector2>();
        direction = direction.normalized;
        return direction;
    }


    public Vector2 GetMouseInput()
    {
        return playerActions.PlayerActionss.CameraView.ReadValue<Vector2>();
    }


}
