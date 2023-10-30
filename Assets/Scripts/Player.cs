using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    [SerializeField] private float speed = 7f;
    [SerializeField] private float mouseSensitivity = .25f;
    [SerializeField] private float interactDistance = 5f;
    [SerializeField] private LayerMask interactMask;

    // Start is called before the first frame update
    [SerializeField] private PlayerInput input;
    [SerializeField] private Transform virtualCamera;
    private CharacterController controller;
    private float yCameraRotation = 0;
    private Transform interactableObject;



    private void Awake()
    {
        controller = GetComponent<CharacterController>();
        yCameraRotation = 0f;
    }

    private void Start()
    {
        input.OnInteractAction += Input_OnInteractAction;
    }

    private void Input_OnInteractAction(object sender, System.EventArgs e)
    {
        if(interactableObject != null)
        {
            interactableObject.TryGetComponent(out IInteractable iinteractable); 
            iinteractable.Interact();
        }
    }

    void Update()
    {
        //Movimiento Basico
        playerWalk();

        //Control de Camara.
        cameraControl();

        //Interaccion
        Interaction();
    }

    private void Interaction()
    {
        if(Physics.Raycast(virtualCamera.position, virtualCamera.forward,out RaycastHit raycastHit, interactDistance, interactMask))
        {
            interactableObject = raycastHit.transform;
        }
        else
        {
            interactableObject = null;
        }
    }

    private void cameraControl()
    {
        //Control de camara
        Vector2 mouseInput = input.GetMouseInput() * mouseSensitivity * Time.deltaTime;

        yCameraRotation -= mouseInput.y;
        yCameraRotation = Mathf.Clamp(yCameraRotation, -90f, 90f);

        virtualCamera.localRotation = Quaternion.Euler(yCameraRotation, 0f, 0f);
        transform.Rotate(Vector3.up, mouseInput.x);
    }

    private void playerWalk()
    {
        //movimiento de personaje
        Vector2 normalizedDir = input.GetMovementDirectionVectorNormalized();
        Vector3 dir = transform.right * normalizedDir.x + transform.forward * normalizedDir.y;
        controller.Move(dir * speed * Time.deltaTime);
    }


}
