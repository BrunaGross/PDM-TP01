using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TP01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void onClickOk(object sender, EventArgs args)
        {
            print("[INFO] Ok\n");
            if (user.Text.Contains("@") && user.Text.Contains(".com"))
            {
                print("[INFO]" + user.Text + " logado com sucesso!");
            }
            else
            {
                print("[ERRO] identificador inválido\n");
            }
        }
        void onClickLimpar(object sender, EventArgs args)
        {
            print("[INFO] Limpar\n");
            user.Text = "";
            pass.Text = "";
            consoleLog.Text = "";
        }
        void onClickCreditos(object sender, EventArgs args)
        {
            print("[INFO] Creditos\n");
            print("Criado por: Bruna Gross CB3001695 e Gabriel Costa CB3001717\n");
        }

        void print(String message)
        {
            consoleLog.Text += message;
        }
    }
}
