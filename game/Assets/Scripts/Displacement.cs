using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Displacement : MonoBehaviour
{
    [SerializeField] private Ball _ball;
    [SerializeField] private Rigidbody _rb;
    private InputSystem _input;
    private bool _isHold = false;
    private Vector3 _screenMousePosition;
    private Vector3 _InGameMousePosition;
    private Camera _camera;
    private float _force;
    private Vector3 _forceVector3 = new Vector3();
    
    private void ForcePlatform()
    {
        Vector3 _screenMousePosition = _input.ActionMap.MoveStickPos.ReadValue<Vector2>();
        _InGameMousePosition = _camera.ScreenToWorldPoint(_screenMousePosition);
        _force = _InGameMousePosition.x - transform.position.x;

        _forceVector3.x = _force * 10;
        _rb.velocity = _forceVector3;
    }

    private void Awake()
    {
        _input = new InputSystem();

        _input.ActionMap.MoveStickFlag.performed += context => _isHold = !_isHold;

        _camera = Camera.main;
    }

    private void OnEnable()
    {
        _input.Enable();
    }

    private void OnDisable()
    {
        _input.Disable();
    }

    void Update()
    {
        if(_isHold) 
        {
            ForcePlatform();
                _ball.isStart = true;
        }
    }
}
