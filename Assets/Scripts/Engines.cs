using UnityEngine;
using System.Collections;

public class Engines : MonoBehaviour {
    private BaseAvatar baseAvatar;
    public Vector2 position = new Vector2(-7, 0);
    public Vector2 speed;
	// Use this for initialization
	void Start () {
        baseAvatar = this.GetComponent<BaseAvatar>();
        this.gameObject.transform.position = this.position;
	}
	
	// Update is called once per frame
	void Update () {
        this.position += speed * baseAvatar.maxSpeed * Time.deltaTime;
        if (this.position.x < -9)
            this.position.x = -9;
        else if (this.position.x > 9)
            this.position.x = 9;
        if (this.position.y < -4.5)
            this.position.y = -4.5f;
        else if (this.position.y > 4.5)
            this.position.y = 4.5f;
        this.gameObject.transform.position = this.position;
    }
}
