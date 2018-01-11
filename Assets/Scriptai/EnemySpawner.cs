using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class EnemySpawner : MonoBehaviour {

   public Object _enemyPrefab;
   public float _spawnRate;
   public int _radius;

    private float _timeSinceLastSpawn;
    public Random Random { get; set; }

    public void Construct(Object enemyPrefab, float spawnRate, int radius)
    {
        _enemyPrefab = enemyPrefab;
        _spawnRate = spawnRate;
        _radius = radius;
    }



	void Update ()
    {
        if (Random == null)
            Random = new Random();

        if(_timeSinceLastSpawn >= _spawnRate)
        {
            

            var enemy = UnityEditor.PrefabUtility.InstantiatePrefab(_enemyPrefab) as GameObject;

            var laipsniai = Random.Next(0, 361);

            var x = _radius * Mathf.Cos(laipsniai * Mathf.Deg2Rad);
            if (Mathf.Abs(x) < 0.01f) x = 0;

            var y = _radius * Mathf.Sin(laipsniai * Mathf.Deg2Rad);
            if (Mathf.Abs(y) < 0.01f) y = 0;

            enemy.transform.position = new Vector3(x, 0, y);

            _timeSinceLastSpawn = 0;
        }
        _timeSinceLastSpawn += Time.deltaTime;
	}
}
