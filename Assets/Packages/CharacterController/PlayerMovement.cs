using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	private Vector2 _playerMovement;
	private Rigidbody2D _rigidbody2D;
	[SerializeField]
	private float moveSpeed = 10f;
	
	// movement / interact methods
	private void Interact() { throw new NotImplementedException(); }
	private void HandleMovement(Vector2 moveInput) { _playerMovement = moveInput; }
	private void FixedUpdate()
	{
		transform.Translate(_playerMovement * (moveSpeed * Time.deltaTime), Space.World);
	}
	
	// initiating / reference handling
	private void Start() { _rigidbody2D = GetComponent<Rigidbody2D>(); }
	private void OnEnable() {
		ActionsManager.MoveEvent += HandleMovement; 
		ActionsManager.InteractEvent += Interact;
	}
	private void OnDisable() {
		ActionsManager.MoveEvent -= HandleMovement;
		ActionsManager.InteractEvent -= Interact;
	}
}
