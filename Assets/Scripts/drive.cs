using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class drive : MonoBehaviour
{

    [SerializeField] private Rigidbody2D _frontTire;
    [SerializeField] private Rigidbody2D _rearTire;
    [SerializeField] public float _speed = 150f;
    [SerializeField] private Rigidbody2D _car;
    [SerializeField] public float _rotationSpeed = 300f;

    private float moveInput;
    public Button gas;
   


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
        if(ButtonHandle.buttonPressed == true) 
        {
            Debug.Log("button is pressed");
            ShovelCoal();
        }
    }

    public void ShovelCoal () {
        _frontTire.AddTorque(-5 *_speed * Time.fixedDeltaTime);
        _rearTire.AddTorque(-5 * _speed * Time.fixedDeltaTime);
        _car.AddTorque(2 * _rotationSpeed * Time.fixedDeltaTime);

    }

}
