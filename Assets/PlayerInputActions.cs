// GENERATED AUTOMATICALLY FROM 'Assets/PlayerInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""f599cb6b-566e-47d7-b677-e1b648ea20c5"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""a4210f13-db9e-44ad-97bb-5a1ab4b21161"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""700e9c36-4d15-4757-a22b-2e9e1aefa93d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Inventory"",
                    ""type"": ""Button"",
                    ""id"": ""6789caf0-d4d9-441e-a56e-b13a1b578139"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""585d4ba2-a486-4d4f-82ca-bfc0e42c9bcb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Menu Close"",
                    ""type"": ""Button"",
                    ""id"": ""3616cb51-d701-44ab-ae89-0158122c5105"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Start Menu"",
                    ""type"": ""Button"",
                    ""id"": ""504400c1-68ad-4e55-b6a9-5aa944d372a1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Drop Item"",
                    ""type"": ""Button"",
                    ""id"": ""afb9529d-5b43-4ea5-98f7-2016c9fb2603"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Swap"",
                    ""type"": ""Button"",
                    ""id"": ""996ac1ab-c1ab-4b1a-9255-5a57ff1b32ec"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Equip"",
                    ""type"": ""Button"",
                    ""id"": ""2b9b32aa-afbc-4256-a5c6-a9359165f861"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""515b84d3-528f-4742-8d6c-6f6edb918ef9"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""0cbc4a7b-96ec-4c0e-962b-0aa72568076e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f1c0bfeb-58e8-4685-9eac-3e1080d279e8"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""0f4c81d8-d69d-4b28-a0fe-e5375ba08c43"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ca788fa7-cdc6-4b8e-bb6e-ab8746013abe"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Dpad"",
                    ""id"": ""40cafdca-ff88-455f-960e-e32ed1e700d9"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""a196797e-5b80-4882-a570-eb98e27348f2"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ae323cb4-a340-4551-82f3-e18d8289b76f"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""a689fb26-324b-4507-8d96-7e1d66324668"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d6f456e8-ba8a-45af-ab0f-6dab2dc59fc0"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""ee3e0d56-fd81-4adc-9b29-17f958b8a004"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""MultiTap"",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a782876c-27fb-41c6-8b72-12604e515ca8"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0fd79e0b-07cb-4751-8235-347971771755"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Inventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9f821d3b-bf31-4874-9ffd-40890b9ffb6c"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Inventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""142984f9-57ca-4c8a-8a33-0d8729a499b0"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cf4a78c6-13e1-4154-8f45-0cc92bccb1dd"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0a2c0d93-c4c4-4dea-99c9-9b052e079dfd"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Menu Close"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c9748036-1259-4d80-ade8-e0e0f8527c89"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Menu Close"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4510aab6-c3ab-4685-a762-20a8633972e5"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Start Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0b8b0eb8-8634-469b-b3f4-4d9996225f3d"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Start Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""261f1e0d-457c-494d-928a-4d1000e1e26f"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Drop Item"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""01d2cfad-f6f9-439c-aef9-d7530545e8f7"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drop Item"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b8ed974e-1e2f-415a-b370-9ba01cf3cc29"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Swap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""42764fae-7149-421c-80dd-c45768fb3f9f"",
                    ""path"": ""<Keyboard>/g"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Swap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ad665a06-4e7c-4717-8c7f-957490a78327"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Equip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8fd46c75-7c73-4b73-b334-f6c40ea77a24"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Equip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard & Mouse"",
            ""bindingGroup"": ""Keyboard & Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
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
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        m_Player_Select = m_Player.FindAction("Select", throwIfNotFound: true);
        m_Player_Inventory = m_Player.FindAction("Inventory", throwIfNotFound: true);
        m_Player_Sprint = m_Player.FindAction("Sprint", throwIfNotFound: true);
        m_Player_MenuClose = m_Player.FindAction("Menu Close", throwIfNotFound: true);
        m_Player_StartMenu = m_Player.FindAction("Start Menu", throwIfNotFound: true);
        m_Player_DropItem = m_Player.FindAction("Drop Item", throwIfNotFound: true);
        m_Player_Swap = m_Player.FindAction("Swap", throwIfNotFound: true);
        m_Player_Equip = m_Player.FindAction("Equip", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Movement;
    private readonly InputAction m_Player_Select;
    private readonly InputAction m_Player_Inventory;
    private readonly InputAction m_Player_Sprint;
    private readonly InputAction m_Player_MenuClose;
    private readonly InputAction m_Player_StartMenu;
    private readonly InputAction m_Player_DropItem;
    private readonly InputAction m_Player_Swap;
    private readonly InputAction m_Player_Equip;
    public struct PlayerActions
    {
        private @PlayerInputActions m_Wrapper;
        public PlayerActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @Select => m_Wrapper.m_Player_Select;
        public InputAction @Inventory => m_Wrapper.m_Player_Inventory;
        public InputAction @Sprint => m_Wrapper.m_Player_Sprint;
        public InputAction @MenuClose => m_Wrapper.m_Player_MenuClose;
        public InputAction @StartMenu => m_Wrapper.m_Player_StartMenu;
        public InputAction @DropItem => m_Wrapper.m_Player_DropItem;
        public InputAction @Swap => m_Wrapper.m_Player_Swap;
        public InputAction @Equip => m_Wrapper.m_Player_Equip;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Select.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSelect;
                @Inventory.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInventory;
                @Inventory.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInventory;
                @Inventory.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInventory;
                @Sprint.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprint;
                @Sprint.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprint;
                @Sprint.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprint;
                @MenuClose.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMenuClose;
                @MenuClose.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMenuClose;
                @MenuClose.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMenuClose;
                @StartMenu.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStartMenu;
                @StartMenu.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStartMenu;
                @StartMenu.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStartMenu;
                @DropItem.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDropItem;
                @DropItem.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDropItem;
                @DropItem.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDropItem;
                @Swap.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwap;
                @Swap.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwap;
                @Swap.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwap;
                @Equip.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEquip;
                @Equip.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEquip;
                @Equip.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEquip;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
                @Inventory.started += instance.OnInventory;
                @Inventory.performed += instance.OnInventory;
                @Inventory.canceled += instance.OnInventory;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
                @MenuClose.started += instance.OnMenuClose;
                @MenuClose.performed += instance.OnMenuClose;
                @MenuClose.canceled += instance.OnMenuClose;
                @StartMenu.started += instance.OnStartMenu;
                @StartMenu.performed += instance.OnStartMenu;
                @StartMenu.canceled += instance.OnStartMenu;
                @DropItem.started += instance.OnDropItem;
                @DropItem.performed += instance.OnDropItem;
                @DropItem.canceled += instance.OnDropItem;
                @Swap.started += instance.OnSwap;
                @Swap.performed += instance.OnSwap;
                @Swap.canceled += instance.OnSwap;
                @Equip.started += instance.OnEquip;
                @Equip.performed += instance.OnEquip;
                @Equip.canceled += instance.OnEquip;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard & Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
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
        void OnMovement(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
        void OnInventory(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnMenuClose(InputAction.CallbackContext context);
        void OnStartMenu(InputAction.CallbackContext context);
        void OnDropItem(InputAction.CallbackContext context);
        void OnSwap(InputAction.CallbackContext context);
        void OnEquip(InputAction.CallbackContext context);
    }
}
