using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class namestring : MonoBehaviour
{
    //[Header("入力文字列（ランダムに見えて再現性あり）")]
    //public string inputString = "HelloWorld";

    //[Header("返す数値の最小値")]
    //public int minValue = 0;

    //[Header("返す数値の最大値")]
    //public int maxValue = 10000000;

    //[SerializeField] private int generatedHash;   // ハッシュ値
    //[SerializeField] private int generatedNumber;

    //void Start()
    //{
    //    generatedHash = inputString.GetHashCode();
    //    generatedNumber = GetNumberFromString(inputString, minValue, maxValue);
    //    Debug.Log($"「{inputString}」 → ハッシュ: {generatedHash} → 数値: {generatedNumber}");
    //}

    ///// <summary>
    ///// 指定された文字列に対応する、再現性のある乱数を返す
    ///// </summary>
    //int GetNumberFromString(string input, int min, int max)
    //{
    //    int seed = input.GetHashCode();
    //    System.Random prng = new System.Random(seed);
    //    return prng.Next(min, max + 1); // max を含めるため +1
    //}

    [Header("バトルする2つの名前")]
    public string name1 = "Hero";
    public string name2 = "Dragon";

    [Header("各ステータスの範囲")]
    public int minStat = 10;
    public int maxStat = 100;

    [Header("キャラ1のステータス")]
    [SerializeField] private int atk1;
    [SerializeField] private int hp1;
    [SerializeField] private int def1;
    [SerializeField] private int spd1;
    [SerializeField] private int crt1;
    [SerializeField] private int luk1;

    [Header("キャラ2のステータス")]
    [SerializeField] private int atk2;
    [SerializeField] private int hp2;
    [SerializeField] private int def2;
    [SerializeField] private int spd2;
    [SerializeField] private int crt2;
    [SerializeField] private int luk2;

    private CharacterStats char1;
    private CharacterStats char2;

    void Start()
    {
        // ステータス生成
        char1 = new CharacterStats(name1, minStat, maxStat);
        char2 = new CharacterStats(name2, minStat, maxStat);

        // インスペクターに値をセット
        SetInspectorValues();

        // バトル！
        SimulateBattle(char1, char2);
    }

    void SetInspectorValues()
    {
        atk1 = char1.ATK;
        hp1 = char1.HP;
        def1 = char1.DEF;
        spd1 = char1.SPD;
        crt1 = char1.CRT;
        luk1 = char1.LUK;

        atk2 = char2.ATK;
        hp2 = char2.HP;
        def2 = char2.DEF;
        spd2 = char2.SPD;
        crt2 = char2.CRT;
        luk2 = char2.LUK;
    }

    void SimulateBattle(CharacterStats a, CharacterStats b)
    {
        Debug.Log($"🗡️ {a.name} vs {b.name} 開始！");

        int hpA = a.HP;
        int hpB = b.HP;

        int turn = 1;
        while (hpA > 0 && hpB > 0)
        {
            Debug.Log($"-- Turn {turn} --");

            int damageA = Mathf.Max(1, a.ATK - b.DEF / 2);
            hpB -= damageA;
            Debug.Log($"{a.name} の攻撃！ {b.name} に {damageA} ダメージ！（残HP: {Mathf.Max(hpB, 0)}）");

            if (hpB <= 0) break;

            int damageB = Mathf.Max(1, b.ATK - a.DEF / 2);
            hpA -= damageB;
            Debug.Log($"{b.name} の攻撃！ {a.name} に {damageB} ダメージ！（残HP: {Mathf.Max(hpA, 0)}）");

            turn++;
        }

        string winner = hpA > 0 ? a.name : b.name;
        Debug.Log($"🎉 勝者: {winner}！");
    }

    class CharacterStats
    {
        public string name;
        public int ATK, HP, DEF, SPD, CRT, LUK;

        public CharacterStats(string name, int min, int max)
        {
            this.name = name;

            int baseHash = name.GetHashCode();

            ATK = GenerateStat(baseHash, 0, min, max);
            HP = GenerateStat(baseHash, 1, min * 2, max * 2);
            DEF = GenerateStat(baseHash, 2, min, max);
            SPD = GenerateStat(baseHash, 3, min, max);
            CRT = GenerateStat(baseHash, 4, min, max);
            LUK = GenerateStat(baseHash, 5, min, max);
        }

        private int GenerateStat(int baseHash, int offset, int min, int max)
        {
            int seed = baseHash + offset * 9999;
            System.Random prng = new System.Random(seed);
            return prng.Next(min, max + 1);
        }
    }
}
 