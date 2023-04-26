using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drive : MonoBehaviour
{

    [SerializeField] private Rigidbody2D _frontTire;
    [SerializeField] private Rigidbody2D _rearTire;
    [SerializeField] private float _speed = 150f;
    [SerializeField] private Rigidbody2D _car;
    [SerializeField] private float _rotationSpeed = 300f;

    private float moveInput;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        moveInput = Input.GetAxisRaw("Horizontal");
        
    }

    private void FixedUpdate(){
        _frontTire.AddTorque(-moveInput * _speed * Time.fixedDeltaTime);
        _rearTire.AddTorque(-moveInput * _speed * Time.fixedDeltaTime);
        _car.AddTorque(moveInput * _rotationSpeed * Time.fixedDeltaTime);
    }
    

}
