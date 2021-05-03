// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Player1.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Player1 : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Player1()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player1"",
    ""maps"": [
        {
            ""name"": ""PlayerControl"",
            ""id"": ""53724d61-06e0-451e-bd2b-07469e7ad7b9"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""4fd645e8-edeb-42a6-a871-b6c51a25dfd2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""981a1c09-ac0b-49cb-b425-c3f896e5d4ca"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""234d5f0d-19b1-43b2-9d01-25a5986788be"",
                    ""path"": ""<HID::Performance Designed Products Afterglow Deluxe+ Audio Wired Controller>/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f42034b0-644e-4541-a48b-749792cad2cb"",
                    ""path"": ""<HID::Performance Designed Products Afterglow Deluxe+ Audio Wired Controller>/button4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9c34f090-264b-44d5-bc02-6891f0bee940"",
                    ""path"": ""<HID::Performance Designed Products Afterglow Deluxe+ Audio Wired Controller>/stick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerControl
        m_PlayerControl = asset.FindActionMap("PlayerControl", throwIfNotFound: true);
        m_PlayerControl_Jump = m_PlayerControl.FindAction("Jump", throwIfNotFound: true);
        m_PlayerControl_Move = m_PlayerControl.FindAction("Move", throwIfNotFound: true);
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

    // PlayerControl
    private readonly InputActionMap m_PlayerControl;
    private IPlayerControlActions m_PlayerControlActionsCallbackInterface;
    private readonly InputAction m_PlayerControl_Jump;
    private readonly InputAction m_PlayerControl_Move;
    public struct PlayerControlActions
    {
        private @Player1 m_Wrapper;
        public PlayerControlActions(@Player1 wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_PlayerControl_Jump;
        public InputAction @Move => m_Wrapper.m_PlayerControl_Move;
        public InputActionMap Get() { return m_Wrapper.m_PlayerControl; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControlActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerControlActions instance)
        {
            if (m_Wrapper.m_PlayerControlActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnJump;
                @Move.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_PlayerControlActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public PlayerControlActions @PlayerControl => new PlayerControlActions(this);
    public interface IPlayerControlActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
    }
}
