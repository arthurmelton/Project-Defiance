// GENERATED AUTOMATICALLY FROM 'Assets/New Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @NewControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @NewControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""New Controls"",
    ""maps"": [
        {
            ""name"": ""player"",
            ""id"": ""364eb63d-ff3e-4caf-abd1-3d68a6159538"",
            ""actions"": [
                {
                    ""name"": ""shoot"",
                    ""type"": ""Button"",
                    ""id"": ""00cb48c3-496d-494d-932f-1b628d1c6eea"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""6b921e1e-2bae-4347-8e17-ffe522192a50"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""look"",
                    ""type"": ""PassThrough"",
                    ""id"": ""2a9c54e2-68d7-401d-9800-0996549a8c19"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ability one"",
                    ""type"": ""Button"",
                    ""id"": ""11b5c4a7-0ae5-4125-821a-07434bb5fc07"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ability two"",
                    ""type"": ""Button"",
                    ""id"": ""d1990fbb-a133-4a18-b8ca-635f3e72244d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""13efabc8-dde1-43e3-b6b5-2c89536c88b4"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&mouse"",
                    ""action"": ""shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""da46df32-cf79-420c-aef4-b47bbc049144"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&mouse;Gamepad"",
                    ""action"": ""shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard&mouse 2D Vector"",
                    ""id"": ""367b46ca-f0ae-4f81-8813-939ecb55b3a1"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""7da5e1f6-bc21-41e4-b732-33083926e3b6"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&mouse"",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""08ffc65b-6df5-483a-85f3-45e804f8b149"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&mouse"",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""3ae69d66-2f4f-4dda-bc2c-47428e0a27cf"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&mouse"",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""0ae07b8d-3053-4c43-aed4-ee6a7bd8e483"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&mouse"",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad 2D Vector"",
                    ""id"": ""0298eb29-a0e3-435f-8524-5c5c7fed5e5a"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""986d48a1-ec3b-4628-a433-fab1cae0c7df"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""cc9bafa7-7972-4dde-8499-33951b2c524b"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""63ce07f3-8a7b-48aa-9663-816ab8e72933"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a1da3977-fb10-476c-a69e-9eaf0cb1c82b"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c948fc3a-688b-4794-b1ca-ca3f4fdcdacf"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&mouse"",
                    ""action"": ""look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bbbb8784-15c2-4913-8b4d-4d196bd992b2"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""28a11fa5-d834-4418-81b3-50aa3a44145d"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&mouse"",
                    ""action"": ""ability one"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""70ee7824-a1f6-4e46-9ca8-2e7309cda155"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ability one"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8dc71f75-2d3e-4d15-aa41-eca366d640f5"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&mouse"",
                    ""action"": ""ability two"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b03424b4-a034-41ea-94a9-9beb54f84446"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ability two"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard&mouse"",
            ""bindingGroup"": ""Keyboard&mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // player
        m_player = asset.FindActionMap("player", throwIfNotFound: true);
        m_player_shoot = m_player.FindAction("shoot", throwIfNotFound: true);
        m_player_movement = m_player.FindAction("movement", throwIfNotFound: true);
        m_player_look = m_player.FindAction("look", throwIfNotFound: true);
        m_player_abilityone = m_player.FindAction("ability one", throwIfNotFound: true);
        m_player_abilitytwo = m_player.FindAction("ability two", throwIfNotFound: true);
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

    // player
    private readonly InputActionMap m_player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_player_shoot;
    private readonly InputAction m_player_movement;
    private readonly InputAction m_player_look;
    private readonly InputAction m_player_abilityone;
    private readonly InputAction m_player_abilitytwo;
    public struct PlayerActions
    {
        private @NewControls m_Wrapper;
        public PlayerActions(@NewControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @shoot => m_Wrapper.m_player_shoot;
        public InputAction @movement => m_Wrapper.m_player_movement;
        public InputAction @look => m_Wrapper.m_player_look;
        public InputAction @abilityone => m_Wrapper.m_player_abilityone;
        public InputAction @abilitytwo => m_Wrapper.m_player_abilitytwo;
        public InputActionMap Get() { return m_Wrapper.m_player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @shoot.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                @shoot.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                @shoot.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                @movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @look.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @look.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @look.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @abilityone.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAbilityone;
                @abilityone.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAbilityone;
                @abilityone.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAbilityone;
                @abilitytwo.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAbilitytwo;
                @abilitytwo.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAbilitytwo;
                @abilitytwo.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAbilitytwo;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @shoot.started += instance.OnShoot;
                @shoot.performed += instance.OnShoot;
                @shoot.canceled += instance.OnShoot;
                @movement.started += instance.OnMovement;
                @movement.performed += instance.OnMovement;
                @movement.canceled += instance.OnMovement;
                @look.started += instance.OnLook;
                @look.performed += instance.OnLook;
                @look.canceled += instance.OnLook;
                @abilityone.started += instance.OnAbilityone;
                @abilityone.performed += instance.OnAbilityone;
                @abilityone.canceled += instance.OnAbilityone;
                @abilitytwo.started += instance.OnAbilitytwo;
                @abilitytwo.performed += instance.OnAbilitytwo;
                @abilitytwo.canceled += instance.OnAbilitytwo;
            }
        }
    }
    public PlayerActions @player => new PlayerActions(this);
    private int m_KeyboardmouseSchemeIndex = -1;
    public InputControlScheme KeyboardmouseScheme
    {
        get
        {
            if (m_KeyboardmouseSchemeIndex == -1) m_KeyboardmouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&mouse");
            return asset.controlSchemes[m_KeyboardmouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnShoot(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnAbilityone(InputAction.CallbackContext context);
        void OnAbilitytwo(InputAction.CallbackContext context);
    }
}
