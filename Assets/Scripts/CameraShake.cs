using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public Animator camAnim1;
    public void CamShake()
    {
        camAnim1.SetTrigger("Shake");
        
    }
}
