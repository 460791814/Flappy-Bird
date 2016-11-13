using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {
    public Vector3 offset;
    private Transform player;
	// Use this for initialization
	void Awake () {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        offset = transform.position - player. position;
        offset = new Vector3(offset.x,0,offset.z);
	}
	
	// Update is called once per frame
	void LateUpdate () {
       
        transform.position = new Vector3(player.position.x,0,0) + offset;
	}
}
