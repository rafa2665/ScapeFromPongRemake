using UnityEngine;
using System.Collections;
[RequireComponent(typeof(Rigidbody2D))]
public class BolaVel : MonoBehaviour {
    Rigidbody2D rb2d;
    GameObject inimigo;
    [SerializeField]
    UnityEngine.UI.Text pontosPlayerTXT, pontosInimigoTXT;
    int pontosPlayer;
    void Start()
    {
        inimigo = GameObject.Find("PaletaInimigo");
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = new Vector2(5, 5);
    }

    void Update()
    {
        if (Input.GetButtonDown("Horizontal"))
            rb2d.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * 3, rb2d.velocity.y);
        float posInimigo;
        posInimigo = Mathf.MoveTowards(inimigo.transform.position.y, transform.position.y, Time.deltaTime * 4);
        inimigo.transform.position = new Vector2(inimigo.transform.position.x, posInimigo);
        pontosPlayerTXT.text = pontosPlayer.ToString();
        Debug.Log(rb2d.velocity);

        if (pontosPlayer == 3)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Escape");
        }
    }

    void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.name == "Col4")
        {
            rb2d.velocity = new Vector2(-5, rb2d.velocity.y);
            pontosPlayerTXT.text = "PontosPlayer: " + pontosPlayer.ToString();
        }
        if (outro.name == "Col2")
        {
            transform.position = new Vector2(0, 0);
            rb2d.velocity = new Vector2(5, 5);
            pontosPlayer += 1;
            rb2d.velocity = new Vector2(5, rb2d.velocity.y);
            pontosPlayerTXT.text = "PontosPlayer: " + pontosPlayer.ToString();
        }
        if (outro.name == "Col1")
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, 5);
            pontosPlayerTXT.text = "PontosPlayer: " + pontosPlayer.ToString();
        }
        if (outro.name == "Col3")
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, -5);
            pontosPlayerTXT.text = "PontosPlayer: " + pontosPlayer.ToString();
        }

        if (outro.name == "PaletaInimigo")
        {
            rb2d.velocity = new Vector2(5, rb2d.velocity.y);
        }
    }
}
