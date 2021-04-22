using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{

#region private 

[SerializeField]
private GameObject _bulletPrefab;

[SerializeField]
private Transform _cannon;

[SerializeField]
private float _bulletSpeed;

[SerializeField]
private float _delayBetweenShots;

private float _nextShotTime;

[SerializeField]
private float _destroyBullet;

#endregion

#region Unity API

private void Update()
{
 if(Input.GetKeyDown("joystick button 7") && (Time.time >= _nextShotTime)){
        FireBullet();
        _nextShotTime = Time.time + _delayBetweenShots;
 }   

}

private void Awake() {
     _nextShotTime = Time.time;
}

#endregion

private void FireBullet(){
   GameObject newbullet =Instantiate(_bulletPrefab,_cannon);
   Bullet bullet= newbullet.GetComponent<Bullet>();
   bullet.Shoot(_bulletSpeed);
   Destroy(newbullet,_destroyBullet);
}
}
