using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	// private PlayerInputActions inputActions;
	private Vector2 _playerMovement;
	private Rigidbody2D _rigidbody2D;
	[SerializeField]
	private float moveSpeed = 10f;
	
	

	private void Interact()
	{
		throw new NotImplementedException();
	}

	private void HandleMovement(Vector2 moveInput)
	{
		// Get movement input from the Input Actions
		_playerMovement = moveInput;
		// Calculate movement direction based on input
		// Vector2 moveDirection = new Vector2(_moveInput.x, _moveInput.y).normalized;
	}
	
	private void FixedUpdate()
	{
		// Move the object
		transform.Translate(_playerMovement * (moveSpeed * Time.deltaTime), Space.World);
	}

	private void Start()
	{
		_rigidbody2D = GetComponent<Rigidbody2D>();
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
