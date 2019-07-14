using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
	public class Boss {
		public int mp = 53;
		public void Magic(int useMp) {
			if(mp > useMp) {
				this.mp -= useMp;
				Debug.Log("魔法攻撃をした。残りmpは" + this.mp );
			} else {
				Debug.Log("MPが足りないため魔法が使えない。");
			}
		}
	}
	
	// Use this for initialization
	void Start () {
		int[] array = {11, 22, 33, 44, 55};
		for(int i = 0; i < array.Length; i++)
			Debug.Log(array[i]);
		int length = array.Length - 1;
		for (int p = length; p >= 0; p--) 
			Debug.Log(array[p]);

		Boss boss = new Boss ();
		for (int m = 0; m <= 10; m++) {
			boss.Magic (5);
		}
	}
	
	// Update is called once per frame
	void Update () {


	}
}