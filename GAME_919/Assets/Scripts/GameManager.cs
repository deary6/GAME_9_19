using UnityEngine;
using UnityEngine.Audio;    // 引用 音頻 API
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // 定義欄位 (宣告變數)
    // 修飾詞 類型 名稱 結尾
    // public 公開 private 私人
    public AudioMixer mixer;

    public Text loadingText;
    public Slider loading;

   // 定義方法 (宣告函式)
   // 修飾詞 類型 名稱 (參數) { 敘述 }
   public void SetVBGM(float value)
    { 
        // 音效管理器.設定浮點數("名稱",值);
        mixer.SetFloat("VBGM", value);
    }

   public void SetVSFX(float value)
    {
        mixer.SetFloat("VSFX", value);
    }

   public void Play()
    {
        SceneManager.LoadScene("AK47場景");
    }
}
