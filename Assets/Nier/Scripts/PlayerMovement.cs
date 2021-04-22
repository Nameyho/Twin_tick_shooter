using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

#region private
private Rigidbody _rigibody;

private Vector3 _movementInput;

[SerializeField]
private float _speed ;

private Vector3 _orientationInput;

#endregion

#region UNITYAPI
private void Awake() {
    _rigibody = GetComponent<Rigidbody>();
}

private void Update() {
    var horizontal = Input.GetAxisRaw("Horizontal");
    var vertical = Input.GetAxisRaw("Vertical");

    _movementInput = new Vector3(horizontal,0,vertical);
    _movementInput.Normalize();

    var orientationHorizontal = Input.GetAxis("Horizontal");
    var orientationVertical = Input.GetAxisRaw("Vertical");
    _orientationInput = new Vector3(orientationHorizontal,0,orientationVertical);
    

}

private void FixedUpdate() {
    
    //calcul la vélocité
    Vector3 velocity = _movementInput * _speed;
    _rigibody.velocity = velocity;
    
    //calcule la rotation après un test
    if(_orientationInput.sqrMagnitude > 0){
    Quaternion lookRotation = Quaternion.LookRotation(_orientationInput);
    _rigibody.MoveRotation(lookRotation);
    }
    

}
#endregion
}
