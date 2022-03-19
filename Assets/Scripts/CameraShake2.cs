using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake2 : MonoBehaviour
{
    public Animator camAnim2;
    public void CamShake2()
    {
        camAnim2.SetTrigger("Shake2");

    }
}
