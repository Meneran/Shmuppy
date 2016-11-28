using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BulletFactory : MonoBehaviour
{
    [SerializeField]
    private GameObject playerBulletPrefab;
    [SerializeField]
    private GameObject enemyBulletPrefab;

    private static Dictionary<BulletType, Queue<GameObject>> availableBullets;

    private static BulletFactory Instance
    {
        get;
        set;
    }

    public static Bullet InstantiateBullet(Vector2 position, BulletType bulletType)
    {
        if (bulletType == BulletType.EnemyBullet)
        {
            GameObject bulletObj = (GameObject)GameObject.Instantiate(BulletFactory.Instance.enemyBulletPrefab, position, Quaternion.identity);
            Bullet bulletComponent = bulletObj.GetComponent<Bullet>();

            return bulletComponent;
        }
        else if (bulletType == BulletType.PlayerBullet)
        {
            GameObject bulletObj = (GameObject)GameObject.Instantiate(BulletFactory.Instance.playerBulletPrefab, position, Quaternion.identity);
            Bullet bulletComponent = bulletObj.GetComponent<Bullet>();

            return bulletComponent;
        }
        else
        {
            Debug.LogError("Bullet Type " + bulletType + "is not handdled");
            return null;
        }
    }

    public static void releaseBullet(Bullet bullet)
    {
        //availableBullets.Add(bullet.bulletType, );
        //bullet.gameObject.SetActive(false);
        if (bullet != null)
            Destroy(bullet.gameObject);
    }

    private void Awake()
    {
        Instance = this;
    }
}
