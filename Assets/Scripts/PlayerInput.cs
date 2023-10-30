using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class PlayerInput : MonoBehaviour
{
    PlayerActions playerActions;

    private void Awake()
    {
        playerActions = new PlayerActions();
        playerActions.PlayerActionss.Enable();
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
