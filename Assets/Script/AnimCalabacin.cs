using UnityEngine;
using System.Collections;

public class AnimCalabacin : MonoBehaviour {
	
	Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Space)) {
			Debug.LogError ("Presione Space!");
			animator.SetTrigger ("walking");
		}
	}
}
