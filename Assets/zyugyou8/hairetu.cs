using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hairetu : MonoBehaviour
{
        [SerializeField] private GameObject whiteCubePrefab;
        [SerializeField] private GameObject blackCubePrefab;
        [SerializeField] private int size = 10;              // 正方形のサイズ（10x10）
        [SerializeField] private float spacing = 1.0f;       // Cube同士の間隔
        [SerializeField] private float spawnInterval = 0.1f; // 生成間隔（秒）

        private GameObject[,] board;

        void Start()
        {
            board = new GameObject[size, size];
            StartCoroutine(GenerateBoardCoroutine());
        }

        IEnumerator GenerateBoardCoroutine()
        {
            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    // 配置位置
                    Vector3 position = new Vector3(x * spacing, 0, y * spacing);

                    // 白黒交互にPrefabを選ぶ
                    GameObject prefabToUse = ((x + y) % 2 == 0) ? whiteCubePrefab : blackCubePrefab;

                    // 生成
                    GameObject cube = Instantiate(prefabToUse, position, Quaternion.identity, transform);
                    board[x, y] = cube;

                    // 指定秒数だけ待ってから次を生成
                    yield return new WaitForSeconds(spawnInterval);
                }
            }
        }
}
