using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

#region private

[SerializeField] private IntVariable _PlayerStartHP;

[SerializeField] private IntVariable _playerCurrentHP;
 
#endregion


private void Awake() {
    _playerCurrentHP.value = _PlayerStartHP.value;
}

}
