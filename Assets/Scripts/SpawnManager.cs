using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _enemyPrefab;
    [SerializeField]
    private GameObject _enemyContainer;
    [SerializeField]
    private GameObject _powerUpPrefab;
   
    private bool _stopSpawning = false;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemyRoutine());
        StartCoroutine(SpawnPowerUpRoutine());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    IEnumerator SpawnEnemyRoutine()
    {
        while(_stopSpawning == false)
        {
            Vector3 posToSpawn = new Vector3(Random.Range(-8, 8), 7, 0);
            GameObject newEnemy =  Instantiate(_enemyPrefab, posToSpawn, Quaternion.identity);
            newEnemy.transform.parent = (_enemyContainer.transform);
            yield return new WaitForSeconds(5.0f);

            
        }

    
    }
    IEnumerator SpawnPowerUpRoutine()
    {
        while (_stopSpawning == false)

        {
            Vector3 powerUpPosToSpawn = new Vector3(Random.Range(-8, 8), 7, 0);
          Instantiate(_powerUpPrefab, powerUpPosToSpawn, Quaternion.identity);
            yield return new WaitForSeconds(Random.Range(3, 8f));


        }
    }
    public void OnPlayerDead()
    {
        _stopSpawning = true;
    }

}
