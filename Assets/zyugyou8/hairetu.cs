using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hairetu : MonoBehaviour
{
        [SerializeField] private GameObject whiteCubePrefab;
        [SerializeField] private GameObject blackCubePrefab;
        [SerializeField] private int size = 10;              // �����`�̃T�C�Y�i10x10�j
        [SerializeField] private float spacing = 1.0f;       // Cube���m�̊Ԋu
        [SerializeField] private float spawnInterval = 0.1f; // �����Ԋu�i�b�j

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
                    // �z�u�ʒu
                    Vector3 position = new Vector3(x * spacing, 0, y * spacing);

                    // �������݂�Prefab��I��
                    GameObject prefabToUse = ((x + y) % 2 == 0) ? whiteCubePrefab : blackCubePrefab;

                    // ����
                    GameObject cube = Instantiate(prefabToUse, position, Quaternion.identity, transform);
                    board[x, y] = cube;

                    // �w��b�������҂��Ă��玟�𐶐�
                    yield return new WaitForSeconds(spawnInterval);
                }
            }
        }
}
