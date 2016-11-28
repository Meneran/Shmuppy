using UnityEngine;
using System.Collections;

public class EnemyBullet : Bullet
{
    public Vector2 position;
    private Vector2 direction = new Vector2(-1, 0);
    // Use this for initialization
    void Start()
    {
        isEnemy = true;
        position = this.gameObject.transform.position;
        bulletType = BulletType.EnemyBullet;
    }

    // Update is called once per frame
    void Update()
    {
        position += this.direction * this.maxSpeed * Time.deltaTime;
        this.gameObject.transform.position = position;
    }

    void OnBecameInvisible()
    {
        BulletFactory.releaseBullet(this);
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        BaseAvatar baseAvatar = collider.GetComponent<BaseAvatar>();
        if (baseAvatar != null)
        {
            if (baseAvatar.isEnemy != this.isEnemy)
            {
                baseAvatar.health--;
                BulletFactory.releaseBullet(this);
            }
        }
        Bullet bullet = collider.GetComponent<Bullet>();
        if (bullet != null)
        {
            if (bullet.isEnemy != this.isEnemy)
            {
                BulletFactory.releaseBullet(this);
            }
        }
    }
}
