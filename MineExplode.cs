using UnityEngine;
using System.Collections;

public class MineExplode : MonoBehaviour 
{
	public AudioClip Hurt;
	public AudioClip Explosion;
	private GameObject Mine;
	
	void Start () 
	{
		particleSystem.Stop();
	}
	
	
	void OnTriggerEnter (Collider other) 
	{
	if (other.tag == "Player")
		{
			particleSystem.Play ();
			audio.PlayOneShot(Hurt);
			audio.PlayOneShot(Explosion);
			Destroy (particleSystem);
			Mine = GameObject.Find ("Mine");
			Mine.GetComponent<MeshRenderer>().enabled = false;
		}
	}
}
