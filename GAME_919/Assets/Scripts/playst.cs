using UnityEngine;
using UnityEngine.UI;

public class playst : MonoBehaviour
{
    [Header("血量與血條")]
    public int hp = 100;        // 血量
    public Slider hpSlider;     // 血量滑桿
    [Header("雞腿區域")]
    public Text textChicken;
    public int ChickenCount;
    public int ChickenTotal;

    public Text textTime;
    public float gameTime;

    // 觸發事件：碰到勾選 IsTrigger 物件會執行一次
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "陷阱")    // 如果 碰到.標籤 等於 "陷阱"
        {
            int d = other.GetComponent<Trap>().damage;  // 取得元件<泛型>().成員
            hp -= d;               // 血量 扣 10
            hpSlider.value = hp;    // 血量滑桿.值 = 血量
        }

        if (other.tag == "雞腿")
        {
            ChickenCount++;
            textChicken.text = "雞腿數量 : " + ChickenCount + " / " + ChickenTotal;
            Destroy(other.gameObject);
        }

        if (other.name == "終點" && ChickenCount == ChickenTotal)
        {
            print("過關");
        }

    }

    private void Start()
    {
        ChickenTotal = GameObject.FindGameObjectsWithTag("雞腿").Length;
        textChicken.text = "雞腿數量:0 / " + ChickenTotal;
    }
    private void OnParticleCollision(GameObject other)
    {
        if (other.tag == "陷阱")    // 如果 碰到.標籤 等於 "陷阱"
        {
            int d = other.GetComponent<Trap>().damage;  // 取得元件<泛型>().成員
            hp -= d;               // 血量 扣 10
            hpSlider.value = hp;    // 血量滑桿.值 = 血量
        }
    }

    private void Update()
    {
        UpdateTime();
    }

    private void UpdateTime()
    {
        gameTime += Time.deltaTime;
        textTime.text = gameTime.ToString("F2");
    }
}
