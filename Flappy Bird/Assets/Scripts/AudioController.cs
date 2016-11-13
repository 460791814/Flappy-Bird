using UnityEngine;
using System.Collections;

public class AudioController : MonoBehaviour {
    public static AudioController Instance;
    public AudioSource audio;
    public AudioClip die;
    public AudioClip hit;
    public AudioClip point;
    public AudioClip wing;
    public AudioClip swooshing;
	// Use this for initialization
	void Awake () {
        Instance = this;
	}
	
	 public void PlayDie()
    {
        audio.PlayOneShot(die);
         
    }
     public void PlayHit()
     {
         audio.PlayOneShot(hit);

     }
     public void PlayPoint()
     {
         audio.PlayOneShot(point);

     }
     public void PlayWing()
     {
         audio.PlayOneShot(wing);

     }
     public void PlaySwooshing()
     {
         audio.PlayOneShot(swooshing);

     }
}
