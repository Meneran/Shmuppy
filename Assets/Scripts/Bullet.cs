using UnityEngine;
using System.Collections;

    public enum BulletType
    {
        PlayerBullet,
        EnemyBullet
    };


public abstract class Bullet : MonoBehaviour {

    public BulletType bulletType;
    //public Vector2 position;
    [SerializeField]
    public float damage;
    [SerializeField]
    public float maxSpeed;

    public bool isEnemy;


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
