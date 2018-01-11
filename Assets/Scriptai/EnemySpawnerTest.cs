using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using NSubstitute;

public class EnemySpawnerTest {
	[UnityTest]
	public IEnumerator InstantiatesGameObjectFromPrefab()
    {
        var enemyPrefab = Resources.Load("Test/enemy");
        var enemySpawner = new GameObject().AddComponent<EnemySpawner>();
        enemySpawner.Construct(enemyPrefab, 0, 1);

        yield return null;

        var spawnedEnemy = GameObject.FindWithTag("enemy");
        var prefabOfTheSpawnedEnemy = UnityEditor.PrefabUtility.GetPrefabParent(spawnedEnemy);
        Assert.AreEqual(enemyPrefab, prefabOfTheSpawnedEnemy);		
	}

    [UnityTest]
    public IEnumerator InstatiatesAtRandom()
    {
        var enemyPrefab = Resources.Load("Test/enemy");
        var enemySpawner = new GameObject().AddComponent<EnemySpawner>();
        enemySpawner.Construct(enemyPrefab, 0, 1);
        var random = NSubstitute.Substitute.For<System.Random>();
        random.Next(Arg.Any<int>(), Arg.Any<int>()).Returns(270);
        enemySpawner.Random = random;

        yield return null;

        var spawnedEnemy = GameObject.FindWithTag("enemy");
        var expectedPosition = new Vector3(0, 0, -1);

        Assert.AreEqual(expectedPosition, spawnedEnemy.transform.position);
    }

    [TearDown]
    public void AfterEveryTest()
    {
        foreach (var gameObject in GameObject.FindGameObjectsWithTag("enemy"))
            Object.Destroy(gameObject);
        foreach (var gameObject in Object.FindObjectsOfType<EnemySpawner>())
            Object.Destroy(gameObject);
    }
}
