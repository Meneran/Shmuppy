using UnityEngine;
using System.Collections;

public class BulletGunEnemy : MonoBehaviour {
    public GameObject bulletObj;

    [SerializeField]
    public float shootingRate;
    private float shootCooldown = 0.2f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (shootCooldown > 0)
            shootCooldown -= Time.deltaTime;
        Attack();
    }

    public void Attack()
    {
        if (shootCooldown <= 0)
        {
            shootCooldown = shootingRate;
            BulletFactory.InstantiateBullet(this.transform.position, BulletType.EnemyBullet);
        }
    }
}
