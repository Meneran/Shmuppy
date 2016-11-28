using UnityEngine;
using System.Collections;

public class InputController : MonoBehaviour {
    private Engines engine;
	// Use this for initialization
	void Start () {
        this.engine = this.GetComponent<Engines>();
	}
	
	// Update is called once per frame
	void Update () {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        bool shoot = Input.GetButton("Fire1");
        if (shoot)
        {
            BulletGunPlayer gun = this.GetComponent<BulletGunPlayer>();
            if (gun != null)
                gun.Attack();
        }

        this.engine.speed = new Vector2(horizontal, vertical);
	}
}
