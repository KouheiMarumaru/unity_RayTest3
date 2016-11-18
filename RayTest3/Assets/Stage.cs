using UnityEngine;
using System.Collections;

public class Stage : MonoBehaviour {

	void OnCollisionEnter(Collision other){
		Destroy (other.gameObject);
	}
}