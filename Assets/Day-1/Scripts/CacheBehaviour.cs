using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CacheBehaviour : MonoBehaviour
{
    public Animator animator
    {
        get
        {
            if (_animator == null)
            {
                _animator = GetComponent<Animator>();
            }

            return _animator;
        }
        private set
        {
            _animator = value;
        }
    }
    private Animator _animator;
}