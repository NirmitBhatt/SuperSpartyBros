using UnityEngine;
using System.Collections;

public class EnemyStun : MonoBehaviour {

    //store camera shake
    private CameraShake shake;

    void Start()
    {
        shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<CameraShake>();
    }

    // if Player hits the stun point of the enemy, then call Stunned on the enemy
    void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "Player")
		{
			// tell the enemy to be stunned
			this.GetComponentInParent<Enemy>().Stunned();
            
            //make the player bounce when enemy is stunned (aka jump)
            other.gameObject.GetComponent<CharacterController2D>().EnemyBounce();
            //trigger CameraShake animation when the player double jumps
            shake.CamShake();
        }
	}
}
