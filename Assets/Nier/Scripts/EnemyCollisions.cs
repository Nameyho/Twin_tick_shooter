using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollisions : MonoBehaviour
{

  #region 

  [SerializeField] private IntVariable _playerCurrentHP;

  [SerializeField] private IntVariable _enemyCount ;

  #endregion


  #region  Unity API
  private void OnCollisionEnter(Collision other) {
          if(other.gameObject.CompareTag("Player")){
            _playerCurrentHP.value -= 1 ;
            Debug.Log(_playerCurrentHP.value);
      }
  }

  private void OnTriggerEnter(Collider other) {

      if(other.gameObject.CompareTag("Bullet")){
        Debug.Log("Balles touchées");
        Destroy(gameObject);
      }
    
  
  }

 private void OnDestroy() {
   _enemyCount.value--;
   Debug.Log(_enemyCount.value);
 }
}
 #endregion