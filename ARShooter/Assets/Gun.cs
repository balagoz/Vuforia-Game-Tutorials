using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {
    public GameObject bulletPrefab;
	private void Update () {
        if (Input.GetMouseButton(0)){
            GameObject go = Instantiate(bulletPrefab, transform.position, transform.rotation) as GameObject;
            go.GetComponent<Rigidbody>().AddForce(transform.forward * 15, ForceMode.Impulse);
        }
	}
}
