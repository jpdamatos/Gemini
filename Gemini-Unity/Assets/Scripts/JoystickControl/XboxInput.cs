// GENERATED AUTOMATICALLY FROM 'Assets/Simulation/SmallModelScene/XboxInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @XboxInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @XboxInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""XboxInput"",
    ""maps"": [
        {
            ""name"": ""Pilot"",
            ""id"": ""581ecd3a-beed-4091-9bc9-9e3dd8f184bd"",
            ""actions"": [
                {
                    ""name"": ""Translation"",
                    ""type"": ""Value"",
                    ""id"": ""d6c9cb3b-da2e-4ca3-ae12-d4922550db12"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sway"",
                    ""type"": ""Value"",
                    ""id"": ""18fe4625-78b5-4409-a5d6-d38c16258eed"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PanTiltCamera"",
                    ""type"": ""Value"",
                    ""id"": ""f3772326-13a5-4221-8ffa-8bd0e6345d2c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ZoomInCamera"",
                    ""type"": ""Value"",
                    ""id"": ""2a8a7b12-4796-499f-86a6-99fe98d02449"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ZoomOutCamera"",
                    ""type"": ""Value"",
                    ""id"": ""0a7ea15e-4d42-46d4-8d8a-9c9412112401"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0000e625-da46-4809-8cfc-e96b8e7d6928"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Translation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""30fcc7af-50ab-42fd-9541-02949c264419"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sway"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""91bc909a-6718-4c31-b3cd-f48ae749a3f2"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PanTiltCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2e2b7876-40cc-4be7-9353-f603b63909f8"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ZoomInCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""20bd5f0c-44ac-45ee-8706-715daf2d88c7"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ZoomOutCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Xbox controller"",
            ""bindingGroup"": ""Xbox controller"",
            ""devices"": [
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Pilot
        m_Pilot = asset.FindActionMap("Pilot", throwIfNotFound: true);
        m_Pilot_Translation = m_Pilot.FindAction("Translation", throwIfNotFound: true);
        m_Pilot_Sway = m_Pilot.FindAction("Sway", throwIfNotFound: true);
        m_Pilot_PanTiltCamera = m_Pilot.FindAction("PanTiltCamera", throwIfNotFound: true);
        m_Pilot_ZoomInCamera = m_Pilot.FindAction("ZoomInCamera", throwIfNotFound: true);
        m_Pilot_ZoomOutCamera = m_Pilot.FindAction("ZoomOutCamera", throwIfNotFound: true);
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

    // Pilot
    private readonly InputActionMap m_Pilot;
    private IPilotActions m_PilotActionsCallbackInterface;
    private readonly InputAction m_Pilot_Translation;
    private readonly InputAction m_Pilot_Sway;
    private readonly InputAction m_Pilot_PanTiltCamera;
    private readonly InputAction m_Pilot_ZoomInCamera;
    private readonly InputAction m_Pilot_ZoomOutCamera;
    public struct PilotActions
    {
        private @XboxInput m_Wrapper;
        public PilotActions(@XboxInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Translation => m_Wrapper.m_Pilot_Translation;
        public InputAction @Sway => m_Wrapper.m_Pilot_Sway;
        public InputAction @PanTiltCamera => m_Wrapper.m_Pilot_PanTiltCamera;
        public InputAction @ZoomInCamera => m_Wrapper.m_Pilot_ZoomInCamera;
        public InputAction @ZoomOutCamera => m_Wrapper.m_Pilot_ZoomOutCamera;
        public InputActionMap Get() { return m_Wrapper.m_Pilot; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PilotActions set) { return set.Get(); }
        public void SetCallbacks(IPilotActions instance)
        {
            if (m_Wrapper.m_PilotActionsCallbackInterface != null)
            {
                @Translation.started -= m_Wrapper.m_PilotActionsCallbackInterface.OnTranslation;
                @Translation.performed -= m_Wrapper.m_PilotActionsCallbackInterface.OnTranslation;
                @Translation.canceled -= m_Wrapper.m_PilotActionsCallbackInterface.OnTranslation;
                @Sway.started -= m_Wrapper.m_PilotActionsCallbackInterface.OnSway;
                @Sway.performed -= m_Wrapper.m_PilotActionsCallbackInterface.OnSway;
                @Sway.canceled -= m_Wrapper.m_PilotActionsCallbackInterface.OnSway;
                @PanTiltCamera.started -= m_Wrapper.m_PilotActionsCallbackInterface.OnPanTiltCamera;
                @PanTiltCamera.performed -= m_Wrapper.m_PilotActionsCallbackInterface.OnPanTiltCamera;
                @PanTiltCamera.canceled -= m_Wrapper.m_PilotActionsCallbackInterface.OnPanTiltCamera;
                @ZoomInCamera.started -= m_Wrapper.m_PilotActionsCallbackInterface.OnZoomInCamera;
                @ZoomInCamera.performed -= m_Wrapper.m_PilotActionsCallbackInterface.OnZoomInCamera;
                @ZoomInCamera.canceled -= m_Wrapper.m_PilotActionsCallbackInterface.OnZoomInCamera;
                @ZoomOutCamera.started -= m_Wrapper.m_PilotActionsCallbackInterface.OnZoomOutCamera;
                @ZoomOutCamera.performed -= m_Wrapper.m_PilotActionsCallbackInterface.OnZoomOutCamera;
                @ZoomOutCamera.canceled -= m_Wrapper.m_PilotActionsCallbackInterface.OnZoomOutCamera;
            }
            m_Wrapper.m_PilotActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Translation.started += instance.OnTranslation;
                @Translation.performed += instance.OnTranslation;
                @Translation.canceled += instance.OnTranslation;
                @Sway.started += instance.OnSway;
                @Sway.performed += instance.OnSway;
                @Sway.canceled += instance.OnSway;
                @PanTiltCamera.started += instance.OnPanTiltCamera;
                @PanTiltCamera.performed += instance.OnPanTiltCamera;
                @PanTiltCamera.canceled += instance.OnPanTiltCamera;
                @ZoomInCamera.started += instance.OnZoomInCamera;
                @ZoomInCamera.performed += instance.OnZoomInCamera;
                @ZoomInCamera.canceled += instance.OnZoomInCamera;
                @ZoomOutCamera.started += instance.OnZoomOutCamera;
                @ZoomOutCamera.performed += instance.OnZoomOutCamera;
                @ZoomOutCamera.canceled += instance.OnZoomOutCamera;
            }
        }
    }
    public PilotActions @Pilot => new PilotActions(this);
    private int m_XboxcontrollerSchemeIndex = -1;
    public InputControlScheme XboxcontrollerScheme
    {
        get
        {
            if (m_XboxcontrollerSchemeIndex == -1) m_XboxcontrollerSchemeIndex = asset.FindControlSchemeIndex("Xbox controller");
            return asset.controlSchemes[m_XboxcontrollerSchemeIndex];
        }
    }
    public interface IPilotActions
    {
        void OnTranslation(InputAction.CallbackContext context);
        void OnSway(InputAction.CallbackContext context);
        void OnPanTiltCamera(InputAction.CallbackContext context);
        void OnZoomInCamera(InputAction.CallbackContext context);
        void OnZoomOutCamera(InputAction.CallbackContext context);
    }
}
