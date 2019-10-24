using UnityEngine;
using UnityEngine.Audio;    // 引用 音頻 API

public class GameManager : MonoBehaviour
{
    // 定義欄位 (宣告變數)
    // 修飾詞 類型 名稱 結尾
    // public 公開 private 私人
     public AudioMixer mixer;

    // 定義方法 (宣告函式)
    // 修飾詞 類型 名稱 (參數) { 敘述 }
    public void SetVBGM(float value)
    {
        mixer.SetFloat("VBGM", value);
    }
}
