using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.PlayerLoop;

public class InputManager : MonoBehaviour, GameInput.IPlayerControlsActions
{
    private GameInput _gameInput;
    private void Awake()
    {
        _gameInput = new GameInput();
        _gameInput.PlayerControls.Enable();
        _gameInput.PlayerControls.SetCallbacks(this);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        ActionsManager.MoveEvent?.Invoke(context.ReadValue<Vector2>());
    }

    void GameInput.IPlayerControlsActions.OnInteract(InputAction.CallbackContext context)
    {
        ActionsManager.InteractEvent?.Invoke();
    }
}
