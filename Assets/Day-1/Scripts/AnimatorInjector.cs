using System;
using UnityEngine;

public class AnimatorInjector : CacheBehaviour
{
    #region Unity API
    private void Update() {
        UpdateAnimatorParameters();
    }

    private void UpdateAnimatorParameters()
    {
      UpdateFloatFromAxis("Horizontal",_animatorSpeedX);
      UpdateFloatFromAxis("Vertical",_animatorSpeedY);
    }

    private void UpdateFloatFromAxis(string axis,int param)
    {
        var x = Input.GetAxis(axis);
        animator.SetFloat(param, x);
    }

    #endregion

    #region Private And Protected

    //detecte automatiquement l'animator sur l'object
    private int _animatorSpeedX = Animator.StringToHash("SpeedX");
    private int _animatorSpeedY = Animator.StringToHash("SpeedY");

    #endregion

}