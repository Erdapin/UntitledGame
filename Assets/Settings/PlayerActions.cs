//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Settings/PlayerActions.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerActions"",
    ""maps"": [
        {
            ""name"": ""PlayerActionss"",
            ""id"": ""f4bd2cd0-98da-4ee1-a38b-4e822efde7f8"",
            ""actions"": [
                {
                    ""name"": ""movement"",
                    ""type"": ""Value"",
                    ""id"": ""3f175a82-0b13-4c84-9b77-73b3672d39e2"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""interact"",
                    ""type"": ""Button"",
                    ""id"": ""5e2e41f5-f9e7-402c-9050-e155060c5812"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""CameraView"",
                    ""type"": ""PassThrough"",
                    ""id"": ""74b96ba8-b693-492c-a1a4-f8ae546c944c"",
                    ""expectedControlType"": ""Delta"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""9db0386e-38b8-44f0-bf37-8f80afe2c38a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""bd8783d8-8655-4218-b2b6-c31741356d4f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""8be3ed89-a73d-4c7d-bda5-b9789aee4139"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""df3318c7-96a9-4962-ab30-e9d020b27da5"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b4e6ed5b-6272-43f0-8613-e682007a0ff9"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""aad9c5bc-f82a-47c5-af2b-ad6c21ce0487"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3113ee0c-1295-4f85-b417-a7ff9c6fea7b"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraView"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerActionss
        m_PlayerActionss = asset.FindActionMap("PlayerActionss", throwIfNotFound: true);
        m_PlayerActionss_movement = m_PlayerActionss.FindAction("movement", throwIfNotFound: true);
        m_PlayerActionss_interact = m_PlayerActionss.FindAction("interact", throwIfNotFound: true);
        m_PlayerActionss_CameraView = m_PlayerActionss.FindAction("CameraView", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // PlayerActionss
    private readonly InputActionMap m_PlayerActionss;
    private List<IPlayerActionssActions> m_PlayerActionssActionsCallbackInterfaces = new List<IPlayerActionssActions>();
    private readonly InputAction m_PlayerActionss_movement;
    private readonly InputAction m_PlayerActionss_interact;
    private readonly InputAction m_PlayerActionss_CameraView;
    public struct PlayerActionssActions
    {
        private @PlayerActions m_Wrapper;
        public PlayerActionssActions(@PlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @movement => m_Wrapper.m_PlayerActionss_movement;
        public InputAction @interact => m_Wrapper.m_PlayerActionss_interact;
        public InputAction @CameraView => m_Wrapper.m_PlayerActionss_CameraView;
        public InputActionMap Get() { return m_Wrapper.m_PlayerActionss; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActionssActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerActionssActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerActionssActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerActionssActionsCallbackInterfaces.Add(instance);
            @movement.started += instance.OnMovement;
            @movement.performed += instance.OnMovement;
            @movement.canceled += instance.OnMovement;
            @interact.started += instance.OnInteract;
            @interact.performed += instance.OnInteract;
            @interact.canceled += instance.OnInteract;
            @CameraView.started += instance.OnCameraView;
            @CameraView.performed += instance.OnCameraView;
            @CameraView.canceled += instance.OnCameraView;
        }

        private void UnregisterCallbacks(IPlayerActionssActions instance)
        {
            @movement.started -= instance.OnMovement;
            @movement.performed -= instance.OnMovement;
            @movement.canceled -= instance.OnMovement;
            @interact.started -= instance.OnInteract;
            @interact.performed -= instance.OnInteract;
            @interact.canceled -= instance.OnInteract;
            @CameraView.started -= instance.OnCameraView;
            @CameraView.performed -= instance.OnCameraView;
            @CameraView.canceled -= instance.OnCameraView;
        }

        public void RemoveCallbacks(IPlayerActionssActions instance)
        {
            if (m_Wrapper.m_PlayerActionssActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerActionssActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerActionssActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerActionssActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerActionssActions @PlayerActionss => new PlayerActionssActions(this);
    public interface IPlayerActionssActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnCameraView(InputAction.CallbackContext context);
    }
}
