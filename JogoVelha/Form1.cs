using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace JogoVelha
{
    public partial class Form1 : Form
    {
        public bool[] status = new bool[9];

        public int contador = 0;
        public Form1()
        {
            InitializeComponent();
            lbl_vezes.Text = "Vez do Jogador 1";
            lbl_teste.Text = null;
            lbl_instrucao.Text = null;
            lbl_resultado.Text = null;
            btn_botao1.Text = null;
            btn_botao2.Text = null;
            btn_botao3.Text = null;
            btn_botao4.Text = null;
            btn_botao5.Text = null;
            btn_botao6.Text = null;
            btn_botao7.Text = null;
            btn_botao8.Text = null;
            btn_botao9.Text = null;

        }
        public void Zerar()
        {
            for (int i = 0; i < status.Length; i++)
            {
                status[i] = false;
            }
            contador = 0;
            lbl_vezes.Text = "Vez do Jogador 1";
            lbl_teste.Text = null;
            lbl_instrucao.Text = null;

            btn_botao1.Text = null;
            btn_botao2.Text = null;
            btn_botao3.Text = null;
            btn_botao4.Text = null;
            btn_botao5.Text = null;
            btn_botao6.Text = null;
            btn_botao7.Text = null;
            btn_botao8.Text = null;
            btn_botao9.Text = null;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (status[0] == true)//OCUPADO
            {
                lbl_instrucao.Text = "Esta vaga esta ocupada, escolha outra!";

            }
            else if (status[0] == false)
            {
                lbl_instrucao.Text = null;
                if (lbl_vezes.Text == "Vez do Jogador 1")
                {
                    btn_botao1.Text = "X";
                    lbl_resultado.Text = null;
                    lbl_vezes.Text = "Vez do Jogador 2";
                    lbl_teste.Text = "Vaga 1 foi ocupada!";
                    status[0] = true;
                    contador++;
                }
                else if (lbl_vezes.Text == "Vez do Jogador 2")
                {
                    btn_botao1.Text = "O";
                    lbl_vezes.Text = "Vez do Jogador 1";
                    lbl_teste.Text = "Vaga 1 foi ocupada!";
                    status[0] = true;
                    contador++;
                }
            }

            Analisar();
        }

        private void btn_botao2_Click(object sender, EventArgs e)
        {
            if (status[1] == true)//OCUPADO
            {
                lbl_instrucao.Text = "Esta vaga esta ocupada, escolha outra!";
            }
            else if (status[1] == false)
            {
                lbl_instrucao.Text = null;
                if (lbl_vezes.Text == "Vez do Jogador 1")
                {
                    btn_botao2.Text = "X";
                    lbl_vezes.Text = "Vez do Jogador 2";
                    lbl_teste.Text = "Vaga 2 foi ocupada!";
                    status[1] = true;
                    contador++;
                }
                else if (lbl_vezes.Text == "Vez do Jogador 2")
                {
                    btn_botao2.Text = "O";
                    lbl_vezes.Text = "Vez do Jogador 1";
                    lbl_teste.Text = "Vaga 2 foi ocupada!";
                    status[1] = true;
                    contador++;
                }
            }

            Analisar();
        }

        private void btn_botao3_Click(object sender, EventArgs e)
        {
            if (status[2] == true)//OCUPADO
            {
                lbl_instrucao.Text = "Esta vaga esta ocupada, escolha outra!";
            }
            else if (status[2] == false)
            {
                lbl_instrucao.Text = null;
                if (lbl_vezes.Text == "Vez do Jogador 1")
                {
                    btn_botao3.Text = "X";
                    lbl_vezes.Text = "Vez do Jogador 2";
                    lbl_teste.Text = "Vaga 3 foi ocupada!";
                    status[2] = true;
                    contador++;
                }
                else if (lbl_vezes.Text == "Vez do Jogador 2")
                {
                    btn_botao3.Text = "O";
                    lbl_vezes.Text = "Vez do Jogador 1";
                    lbl_teste.Text = "Vaga 3 foi ocupada!";
                    status[2] = true;
                    contador++;
                }
            }
            Analisar();
        }

        private void btn_botao4_Click(object sender, EventArgs e)
        {
            if (status[3] == true)//OCUPADO
            {
                lbl_instrucao.Text = "Esta vaga esta ocupada, escolha outra!";
            }
            else if (status[3] == false)
            {
                lbl_instrucao.Text = null;
                if (lbl_vezes.Text == "Vez do Jogador 1")
                {
                    btn_botao4.Text = "X";
                    lbl_vezes.Text = "Vez do Jogador 2";
                    lbl_teste.Text = "Vaga 4 foi ocupada!";
                    status[3] = true;
                    contador++;
                }
                else if (lbl_vezes.Text == "Vez do Jogador 2")
                {
                    btn_botao4.Text = "O";
                    lbl_vezes.Text = "Vez do Jogador 1";
                    lbl_teste.Text = "Vaga 4 foi ocupada!";
                    status[3] = true;
                    contador++;
                }
            }
            Analisar();
        }

        private void btn_botao5_Click(object sender, EventArgs e)
        {
            if (status[4] == true)//OCUPADO
            {
                lbl_instrucao.Text = "Esta vaga esta ocupada, escolha outra!";
            }
            else if (status[4] == false)
            {
                lbl_instrucao.Text = null;
                if (lbl_vezes.Text == "Vez do Jogador 1")
                {
                    btn_botao5.Text = "X";
                    lbl_vezes.Text = "Vez do Jogador 2";
                    lbl_teste.Text = "Vaga 5 foi ocupada!";
                    status[4] = true;
                    contador++;
                }
                else if (lbl_vezes.Text == "Vez do Jogador 2")
                {
                    btn_botao5.Text = "O";
                    lbl_vezes.Text = "Vez do Jogador 1";
                    lbl_teste.Text = "Vaga 5 foi ocupada!";
                    status[4] = true;
                    contador++;
                }
            }
            Analisar();
        }

        private void btn_botao6_Click(object sender, EventArgs e)
        {
            if (status[5] == true)
            {
                lbl_instrucao.Text = "Esta vaga esta ocupada, escolha outra!";
            }
            else if (status[5] == false)
            {
                lbl_instrucao.Text = null;
                if (lbl_vezes.Text == "Vez do Jogador 1")
                {
                    btn_botao6.Text = "X";
                    lbl_vezes.Text = "Vez do Jogador 2";
                    lbl_teste.Text = "Vaga 6 foi ocupada!";
                    status[5] = true;
                    contador++;
                }
                else if (lbl_vezes.Text == "Vez do Jogador 2")
                {
                    btn_botao6.Text = "O";
                    lbl_vezes.Text = "Vez do Jogador 1";
                    lbl_teste.Text = "Vaga 6 foi ocupada!";
                    status[5] = true;
                    contador++;
                }
            }
            Analisar();
        }

        private void btn_botao7_Click(object sender, EventArgs e)
        {
            if (status[6] == true)//OCUPADO
            {
                lbl_instrucao.Text = "Esta vaga esta ocupada, escolha outra!";
            }
            else if (status[6] == false)
            {
                lbl_instrucao.Text = null;
                if (lbl_vezes.Text == "Vez do Jogador 1")
                {
                    btn_botao7.Text = "X";
                    lbl_vezes.Text = "Vez do Jogador 2";
                    lbl_teste.Text = "Vaga 7 foi ocupada!";
                    status[6] = true;
                    contador++;
                }
                else if (lbl_vezes.Text == "Vez do Jogador 2")
                {
                    btn_botao7.Text = "O";
                    lbl_vezes.Text = "Vez do Jogador 1";
                    lbl_teste.Text = "Vaga 7 foi ocupada!";
                    status[6] = true;
                    contador++;
                }
            }
            Analisar();
        }

        private void btn_botao8_Click(object sender, EventArgs e)
        {
            if (status[7] == true)//OCUPADO
            {
                lbl_instrucao.Text = "Esta vaga esta ocupada, escolha outra!";
            }
            else if (status[7] == false)
            {
                lbl_instrucao.Text = null;
                if (lbl_vezes.Text == "Vez do Jogador 1")
                {
                    btn_botao8.Text = "X";
                    lbl_vezes.Text = "Vez do Jogador 2";
                    lbl_teste.Text = "Vaga 8 foi ocupada!";
                    status[7] = true;
                    contador++;
                }
                else if (lbl_vezes.Text == "Vez do Jogador 2")
                {
                    btn_botao8.Text = "O";
                    lbl_vezes.Text = "Vez do Jogador 1";
                    lbl_teste.Text = "Vaga 8 foi ocupada!";
                    status[7] = true;
                    contador++;
                }
            }
            Analisar();
        }

        private void btn_botao9_Click(object sender, EventArgs e)
        {
            if (status[8] == true)//OCUPADO
            {
                lbl_instrucao.Text = "Esta vaga esta ocupada, escolha outra!";
            }
            else if (status[8] == false)
            {
                lbl_instrucao.Text = null;
                if (lbl_vezes.Text == "Vez do Jogador 1")
                {
                    btn_botao9.Text = "X";
                    lbl_vezes.Text = "Vez do Jogador 2";
                    lbl_teste.Text = "Vaga 9 foi ocupada!";
                    status[8] = true;
                    contador++;
                }
                else if (lbl_vezes.Text == "Vez do Jogador 2")
                {
                    btn_botao9.Text = "O";
                    lbl_vezes.Text = "Vez do Jogador 1";
                    lbl_teste.Text = "Vaga 9 foi ocupada!";
                    status[8] = true;
                    contador++;
                }
            }
            Analisar();
        }

        public void Analisar()
        {
            //COLUNAS
            if (btn_botao1.Text == "X" && btn_botao2.Text == "X" && btn_botao3.Text == "X")
            {
                lbl_resultado.Text = "Jogador 1 venceu!";
                Zerar();

            }
            if (btn_botao1.Text == "O" && btn_botao2.Text == "O" && btn_botao3.Text == "O")
            {
                lbl_resultado.Text = "Jogador 2 venceu!";
                Zerar();

            }

            if (btn_botao4.Text == "X" && btn_botao5.Text == "X" && btn_botao6.Text == "X")
            {
                lbl_resultado.Text = "Jogador 1 venceu!";
                Zerar();

            }
            if (btn_botao4.Text == "O" && btn_botao5.Text == "O" && btn_botao6.Text == "O")
            {
                lbl_resultado.Text = "Jogador 2 venceu!";
                Zerar();

            }

            if (btn_botao7.Text == "X" && btn_botao8.Text == "X" && btn_botao9.Text == "X")
            {
                lbl_resultado.Text = "Jogador 1 venceu!";
                Zerar();

            }
            if (btn_botao7.Text == "O" && btn_botao8.Text == "O" && btn_botao9.Text == "O")
            {
                lbl_resultado.Text = "Jogador 2 venceu!";
                Zerar();

            }

            //LINHAS

            if (btn_botao1.Text == "X" && btn_botao4.Text == "X" && btn_botao7.Text == "X")
            {
                lbl_resultado.Text = "Jogador 1 venceu!";
                Zerar();

            }
            if (btn_botao1.Text == "O" && btn_botao4.Text == "O" && btn_botao7.Text == "O")
            {
                lbl_resultado.Text = "Jogador 2 venceu!";
                Zerar();

            }

            if (btn_botao2.Text == "X" && btn_botao5.Text == "X" && btn_botao8.Text == "X")
            {
                lbl_resultado.Text = "Jogador 1 venceu!";
                Zerar();

            }
            if (btn_botao2.Text == "O" && btn_botao5.Text == "O" && btn_botao8.Text == "O")
            {
                lbl_resultado.Text = "Jogador 2 venceu!";
                Zerar();

            }

            if (btn_botao3.Text == "X" && btn_botao6.Text == "X" && btn_botao9.Text == "X")
            {
                lbl_resultado.Text = "Jogador 1 venceu!";
                Zerar();

            }
            if (btn_botao3.Text == "O" && btn_botao6.Text == "O" && btn_botao9.Text == "O")
            {
                lbl_resultado.Text = "Jogador 2 venceu!";
                Zerar();
            }

            //DIAGONAIS

            if (btn_botao3.Text == "X" && btn_botao5.Text == "X" && btn_botao7.Text == "X")
            {
                lbl_resultado.Text = "Jogador 1 venceu!";
                Zerar();

            }
            if (btn_botao3.Text == "O" && btn_botao5.Text == "O" && btn_botao7.Text == "O")
            {
                lbl_resultado.Text = "Jogador 2 venceu!";
                Zerar();

            }

            if (btn_botao1.Text == "X" && btn_botao5.Text == "X" && btn_botao9.Text == "X")
            {
                lbl_resultado.Text = "Jogador 1 venceu!";
                Zerar();

            }
            if (btn_botao1.Text == "O" && btn_botao5.Text == "O" && btn_botao9.Text == "O")
            {
                lbl_resultado.Text = "Jogador 2 venceu!";
                Zerar();

            }

            //EMPATE

            else if (contador == 9)
            {
                lbl_resultado.Text = "Empate";
                Zerar();
            }
        }

        private void lbl_instrucao_Click(object sender, EventArgs e)
        {

        }
    }
}