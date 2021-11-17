using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    [SerializeField] List<GameObject> enemyList;

    int enemychoice = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

 


    IEnumerator SpawnEnemies()
    {
        int enemycount = 0;
        while (true)
        {
            enemychoice = Random.Range(0, enemyList.Count);
            enemycount++;
            float xspawnpos = Random.Range(GameData.GetXMin(), GameData.GetXMax());
            Instantiate( enemyList[enemychoice] , new Vector3(xspawnpos, GameData.GetYMax() + 1f), Quaternion.identity);
            if (enemycount >= 10) break;
            yield return new WaitForSeconds(0.5f);
            
        }
    }



}
