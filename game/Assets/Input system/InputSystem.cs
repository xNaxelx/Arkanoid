// GENERATED AUTOMATICALLY FROM 'Assets/Input system/InputSystem.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputSystem : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputSystem()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputSystem"",
    ""maps"": [
        {
            ""name"": ""ActionMap"",
            ""id"": ""579bd001-8b6f-47ad-bd96-315da1722822"",
            ""actions"": [
                {
                    ""name"": ""MoveStickFlag"",
                    ""type"": ""Button"",
                    ""id"": ""da7eed1c-6fbc-43f3-bef5-21675ad7eed9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveStickPos"",
                    ""type"": ""Value"",
                    ""id"": ""1b6a7990-72c7-4831-83d7-a888a8cba294"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d247fd00-490c-42dc-87c4-0d95e048ad7e"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveStickFlag"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c13a272b-83eb-4eea-9260-dc92c602b0a4"",
                    ""path"": ""<Touchscreen>/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveStickFlag"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""614733ed-0c8c-4ac2-a810-def57bcf812b"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveStickPos"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""76c32b8e-e637-4601-92c7-ccdc6b3fb931"",
                    ""path"": ""<Touchscreen>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveStickPos"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // ActionMap
        m_ActionMap = asset.FindActionMap("ActionMap", throwIfNotFound: true);
        m_ActionMap_MoveStickFlag = m_ActionMap.FindAction("MoveStickFlag", throwIfNotFound: true);
        m_ActionMap_MoveStickPos = m_ActionMap.FindAction("MoveStickPos", throwIfNotFound: true);
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

    // ActionMap
    private readonly InputActionMap m_ActionMap;
    private IActionMapActions m_ActionMapActionsCallbackInterface;
    private readonly InputAction m_ActionMap_MoveStickFlag;
    private readonly InputAction m_ActionMap_MoveStickPos;
    public struct ActionMapActions
    {
        private @InputSystem m_Wrapper;
        public ActionMapActions(@InputSystem wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveStickFlag => m_Wrapper.m_ActionMap_MoveStickFlag;
        public InputAction @MoveStickPos => m_Wrapper.m_ActionMap_MoveStickPos;
        public InputActionMap Get() { return m_Wrapper.m_ActionMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ActionMapActions set) { return set.Get(); }
        public void SetCallbacks(IActionMapActions instance)
        {
            if (m_Wrapper.m_ActionMapActionsCallbackInterface != null)
            {
                @MoveStickFlag.started -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnMoveStickFlag;
                @MoveStickFlag.performed -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnMoveStickFlag;
                @MoveStickFlag.canceled -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnMoveStickFlag;
                @MoveStickPos.started -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnMoveStickPos;
                @MoveStickPos.performed -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnMoveStickPos;
                @MoveStickPos.canceled -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnMoveStickPos;
            }
            m_Wrapper.m_ActionMapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveStickFlag.started += instance.OnMoveStickFlag;
                @MoveStickFlag.performed += instance.OnMoveStickFlag;
                @MoveStickFlag.canceled += instance.OnMoveStickFlag;
                @MoveStickPos.started += instance.OnMoveStickPos;
                @MoveStickPos.performed += instance.OnMoveStickPos;
                @MoveStickPos.canceled += instance.OnMoveStickPos;
            }
        }
    }
    public ActionMapActions @ActionMap => new ActionMapActions(this);
    public interface IActionMapActions
    {
        void OnMoveStickFlag(InputAction.CallbackContext context);
        void OnMoveStickPos(InputAction.CallbackContext context);
    }
}
