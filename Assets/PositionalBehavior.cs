using UnityEngine;

public class PositionalBehavior : MonoBehaviour {
    public GameObject player;
    public Vector3 followingDistance;
	// Use this for initialization
	void Start () {
        followingDistance = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = player.transform.position + followingDistance;
	}
}
