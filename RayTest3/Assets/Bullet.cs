using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	void Start(){

	}

	void Update(){

	}

	void OnCollisionEnter(Collision other) {
		if (other.gameObject.tag == "enemy") {
			//ぶつかってきたオブジェクトのタグが「enemy」だったら」

			Destroy (other.gameObject);
			//ぶつかってきたオブジェクトであるother.gameObjectをDestroyメソッドで削除

			Destroy (this.gameObject);
			//自分自身を表すthis.gameObjectをDestroyメソッドで削除
		}
	}
}