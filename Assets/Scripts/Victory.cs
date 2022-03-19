using UnityEngine;
using System.Collections;

public class Victory : MonoBehaviour {

	public bool taken = false;
	public GameObject explosion;
    public GameObject DummySparty;

	// if the player touches the victory object, it has not already been taken, and the player can move (not dead or victory)
	// then the player has reached the victory point of the level
	void OnTriggerEnter2D (Collider2D other)
	{

		if ((other.tag == "Player" ) && (!taken) && (other.gameObject.GetComponent<CharacterController2D>().playerCanMove))
		{
			// mark as taken so doesn't get taken multiple times
			taken=true;

            //Re-aligning the dummy sparty object that the camera follows 
            DummySparty.transform.position = new Vector3(-22.4f, -3.15f, transform.position.z);

			// if explosion prefab is provide, then instantiate it
			if (explosion)
			{
				Instantiate(explosion,transform.position,transform.rotation);
			}

			// do the player victory thing
			other.gameObject.GetComponent<CharacterController2D>().Victory();

			// destroy the victory gameobject
			DestroyObject(this.gameObject);
		}
	}

}
