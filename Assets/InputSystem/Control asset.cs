//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/InputSystem/Control asset.inputactions
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

public partial class @Controlasset: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controlasset()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Control asset"",
    ""maps"": [
        {
            ""name"": ""Clicker"",
            ""id"": ""6b13e41e-faf0-479e-a321-681ca1efce6a"",
            ""actions"": [],
            ""bindings"": []
        }
    ],
    ""controlSchemes"": []
}");
        // Clicker
        m_Clicker = asset.FindActionMap("Clicker", throwIfNotFound: true);
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

    // Clicker
    private readonly InputActionMap m_Clicker;
    private List<IClickerActions> m_ClickerActionsCallbackInterfaces = new List<IClickerActions>();
    public struct ClickerActions
    {
        private @Controlasset m_Wrapper;
        public ClickerActions(@Controlasset wrapper) { m_Wrapper = wrapper; }
        public InputActionMap Get() { return m_Wrapper.m_Clicker; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ClickerActions set) { return set.Get(); }
        public void AddCallbacks(IClickerActions instance)
        {
            if (instance == null || m_Wrapper.m_ClickerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_ClickerActionsCallbackInterfaces.Add(instance);
        }

        private void UnregisterCallbacks(IClickerActions instance)
        {
        }

        public void RemoveCallbacks(IClickerActions instance)
        {
            if (m_Wrapper.m_ClickerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IClickerActions instance)
        {
            foreach (var item in m_Wrapper.m_ClickerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_ClickerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public ClickerActions @Clicker => new ClickerActions(this);
    public interface IClickerActions
    {
    }
}