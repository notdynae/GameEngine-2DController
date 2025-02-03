using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class ActionsManager : MonoBehaviour
{
    public static Action <Vector2>MoveEvent;
    public static Action InteractEvent;
    
    public InputActionMap gameplayActions;
}
