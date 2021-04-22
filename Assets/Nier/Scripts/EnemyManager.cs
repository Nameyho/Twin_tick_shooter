using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{

    [SerializeField]
    private IntVariable _enemyCount;

    private void Awake() {
        int nbrEnemy = GameObject.FindGameObjectsWithTag("Enemy").Length;
        _enemyCount.value = nbrEnemy;
    }

}
