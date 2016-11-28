using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BulletGunPlayer : MonoBehaviour {
    private bool canAttack = true;
    public int energy;
    private float waitingTime = 0;

    [SerializeField]
    public float shootingRate;
    private float shootCooldown = 0f;
    // Use this for initialization
	void Start () {
        energy = 100;
	}
	void Update () {
        if (shootCooldown > 0)
            shootCooldown -= Time.deltaTime;
        if (canAttack)
            energy++;
        if (Time.realtimeSinceStartup - waitingTime > 0.5)
        {
            canAttack = true;
            energy = 100;
        }
    }
    public void Attack()
    {
        if (shootCooldown <= 0 && canAttack)
        {
            shootCooldown = shootingRate;
            energy -= 5;
            //Instantiate(bulletObj, this.gameObject.transform.position, Quaternion.identity);
            BulletFactory.InstantiateBullet(this.gameObject.transform.position, BulletType.PlayerBullet);
            waitingTime = Time.realtimeSinceStartup;

            if (energy <= 0)
            {
                canAttack = false;
            }
        }
    }
}
