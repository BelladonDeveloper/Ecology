using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof (BoxCollider))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private FixedJoystick _joystick;
    [SerializeField] private Animator _animator;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _JumpSpeed = 6f;
    [SerializeField] private bool _isGround;
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }
    //Player jump
    
    // Update is called once per frame
    private void FixedUpdate()
    {
         _rigidbody.velocity = new Vector3(_joystick.Horizontal * _moveSpeed, _rigidbody.velocity.y, _joystick.Vertical * _moveSpeed);

         if(_joystick.Horizontal != 0 || _joystick.Vertical != 0)
         {
             if (_isGround == true)
        {
             _rigidbody.MoveRotation(Quaternion.LookRotation(_rigidbody.velocity));
             _animator.SetBool("IsWalking", true);
    
        }
            
         }
         else
         {
             _animator.SetBool("IsWalking", false);
         }
    }

    public void OnJumpBottonDown()
    {
        if (_isGround == true)
        {
            _rigidbody.velocity = Vector3.up * _JumpSpeed;
    
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            _isGround = true;
        }
        else
        {
            _isGround = false;
        }
    }

}

