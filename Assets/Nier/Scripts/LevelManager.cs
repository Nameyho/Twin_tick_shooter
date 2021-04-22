using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    #region  private
 [SerializeField] private IntVariable _playerCurrentHP;

  [SerializeField] private IntVariable _enemyCount ;

  #endregion

#region Unity API


    private void Update() {
        if(_enemyCount.value <= 0){
            Win();
        }

        if(_playerCurrentHP.value <= 0){
            Lose();
        }
    }


#endregion


  #region 

    private void Win(){
        Debug.Log("victoire");
    }

    private void Lose(){
            Debug.Log("Défaite");
    }

  #endregion
}

