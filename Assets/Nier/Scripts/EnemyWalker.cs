using UnityEngine;

public class EnemyWalker : MonoBehaviour
{

    #region private 

    [SerializeField]
    private Transform _playerTransform;

    private Transform _EnemyWalkerTransform;

    [SerializeField]
    private float _speedRotation;

    [SerializeField]
    private float _speed;

    private Rigidbody _EnemyWalkerRigidBody;

    #endregion

    #region Unity API
    private void Awake()
    {
        _EnemyWalkerTransform = transform;
        _EnemyWalkerRigidBody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        TurnTowardPlayer();
    }

    #endregion

    #region 

    private void TurnTowardPlayer()
    {
        // position joueur - position ennemy
        Vector3 target = _playerTransform.position - transform.position;
      
        Quaternion rotationEnemy = Quaternion.LookRotation(target);
        Quaternion finalrotation = Quaternion.RotateTowards(_EnemyWalkerTransform.rotation, rotationEnemy,
                                                                     Time.deltaTime * _speedRotation );
        _EnemyWalkerRigidBody.MoveRotation(finalrotation);
        _EnemyWalkerRigidBody.velocity= _EnemyWalkerTransform.forward * _speed;
    }

    #endregion

}


// 