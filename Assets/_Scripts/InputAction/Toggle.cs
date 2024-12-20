//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/_Scripts/InputAction/Toggle.inputactions
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

public partial class @Toggle: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Toggle()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Toggle"",
    ""maps"": [
        {
            ""name"": ""ToggleNotepad"",
            ""id"": ""d5a2cecd-1233-447a-b320-89208d6f34e6"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""5480d989-6330-412a-b6f6-bbd3a0834916"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5511b9dc-9ffe-4436-8e97-8f42f3ed37ff"",
                    ""path"": ""<XRController>{LeftHand}/{PrimaryButton}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // ToggleNotepad
        m_ToggleNotepad = asset.FindActionMap("ToggleNotepad", throwIfNotFound: true);
        m_ToggleNotepad_Newaction = m_ToggleNotepad.FindAction("New action", throwIfNotFound: true);
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

    // ToggleNotepad
    private readonly InputActionMap m_ToggleNotepad;
    private List<IToggleNotepadActions> m_ToggleNotepadActionsCallbackInterfaces = new List<IToggleNotepadActions>();
    private readonly InputAction m_ToggleNotepad_Newaction;
    public struct ToggleNotepadActions
    {
        private @Toggle m_Wrapper;
        public ToggleNotepadActions(@Toggle wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_ToggleNotepad_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_ToggleNotepad; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ToggleNotepadActions set) { return set.Get(); }
        public void AddCallbacks(IToggleNotepadActions instance)
        {
            if (instance == null || m_Wrapper.m_ToggleNotepadActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_ToggleNotepadActionsCallbackInterfaces.Add(instance);
            @Newaction.started += instance.OnNewaction;
            @Newaction.performed += instance.OnNewaction;
            @Newaction.canceled += instance.OnNewaction;
        }

        private void UnregisterCallbacks(IToggleNotepadActions instance)
        {
            @Newaction.started -= instance.OnNewaction;
            @Newaction.performed -= instance.OnNewaction;
            @Newaction.canceled -= instance.OnNewaction;
        }

        public void RemoveCallbacks(IToggleNotepadActions instance)
        {
            if (m_Wrapper.m_ToggleNotepadActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IToggleNotepadActions instance)
        {
            foreach (var item in m_Wrapper.m_ToggleNotepadActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_ToggleNotepadActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public ToggleNotepadActions @ToggleNotepad => new ToggleNotepadActions(this);
    public interface IToggleNotepadActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
