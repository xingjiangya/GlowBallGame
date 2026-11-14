using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class PlayerController : MonoBehaviour
{
    //我们需要在面板里面把 Text 拖进来
    private int score = 0;
    [Header("UI 引用")]
    public TextMeshProUGUI scoreText;

    [Header("移动参数")]
    public float speed = 10f;
    private Rigidbody rb;
    public GameObject explosionPrefab;
    public GameObject winText;
    public int totalCoins = 6;

    // Start is called before the first frame update
    public Material playerMaterial;
    void Start()
    {
        rb = GetComponent<Rigidbody>();


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
           rb.AddForce(movement * speed);

    }

    //当有东西碰到你时，会自动执行这个方法
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin")) 
        {
            Destroy(other.gameObject);
            Debug.Log("吃掉一个金币");

            //下面这三行才是真正让分数变化的魔法，你看看你是不是漏了
            score = score + 1;
            scoreText.text = "Score: " + score;
            //如果吃掉金币等于总金币数
            if (score >= totalCoins)
            {
                winText.SetActive(true);
                Time.timeScale = 0f;
            }

            //呼叫协程必须放在吃金币的if里面
            StartCoroutine(FlashGreen());
            //在你吃金币的位置生成一个爆炸特效
            GameObject fx = Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            //2秒后自动销毁这个特效，保持场景干净
            Destroy(fx, 2f);

        }

        
    }
     
    System.Collections.IEnumerator FlashGreen()
    {
        playerMaterial.color = Color.green;

        yield return new WaitForSeconds(0.2f);

        playerMaterial.color = Color.white;

    }

}
