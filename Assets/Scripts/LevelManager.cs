using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;


public class LevelManager : MonoBehaviour
{
    void Start()
    {
        Level defaultLevel = new Level();
        XmlHelpers.SaveToXML<Level>(Application.dataPath + "/test.xml", defaultLevel);
    }
}

public class Level
{
    public string levelName { get; set; }

    public List<LevelEnemy> enemyList = new List<LevelEnemy>();

    public Level()
    {
        this.levelName = "Default";
        for (int i = 0; i < 10; ++i) { 
            LevelEnemy defaultLevel = new LevelEnemy(Random.Range(-4f, 4f), 2 * i);
            this.enemyList.Add(defaultLevel);
        }
    }
}


public class LevelEnemy
{
    public float spawnHeight;
    public float spawnTime;

    public LevelEnemy()
    {
        this.spawnHeight = 0;
        this.spawnTime = 0;
    }

    public LevelEnemy(float height, float time)
    {
        this.spawnHeight = height;
        this.spawnTime = time;
    }
}