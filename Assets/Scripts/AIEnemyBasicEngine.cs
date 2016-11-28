using UnityEngine;
using System.Collections;

public class AIEnemyBasicEngine : MonoBehaviour {
    public Vector2 position;
    [SerializeField]
    public Vector2 speed = new Vector2(-1, 0);

    private BaseAvatar baseAvatar;
	// Use this for initialization
	void Start () {
        this.position += new Vector2(0, Random.Range(-4.0f, 4.0f));
        this.baseAvatar = this.GetComponent<BaseAvatar>();
        this.gameObject.transform.position = this.position; 
	}
	
	// Update is called once per frame
	void Update () {
        this.position += this.speed * baseAvatar.maxSpeed * Time.deltaTime;
        this.gameObject.transform.position = this.position;
	}
}
