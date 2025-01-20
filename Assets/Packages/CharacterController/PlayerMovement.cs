using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	// private PlayerInputActions inputActions;
	private Vector2 _moveInput;
	[SerializeField]
	private float moveSpeed = 5f;
	

	private void Interact()
	{
		throw new NotImplementedException();
	}

	private void HandleMovement()
	{
		// Get movement input from the Input Actions
		// _moveInput = ActionsManager.MoveEvent.
		// Calculate movement direction based on input
		// Vector2 moveDirection = new Vector2(_moveInput.x, _moveInput.y).normalized;
	}
	
	private void FixedUpdate()
	{
		// Move the object
		// transform.Translate(moveDirection * (moveSpeed * Time.deltaTime), Space.World);
	}
	private void OnEnable()
	{
		ActionsManager.MoveEvent += HandleMovement; 
		ActionsManager.InteractEvent += Interact;
		
	}
	private void OnDisable()
	{
		ActionsManager.MoveEvent -= HandleMovement;
		ActionsManager.InteractEvent -= Interact;
	}

}
