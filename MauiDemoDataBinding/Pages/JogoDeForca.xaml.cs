using System.ComponentModel;
using System.Diagnostics;

namespace MauiDemoDataBinding.Pages;

public partial class JogoDeForca : ContentPage, INotifyPropertyChanged
{


    #region Fields
    private string destaque;
    private List<char> letras;
    private string mensagem;
    private string statusJogo;
    private string imagemAtual = "zombiemountain.png";
    List<string> palavras = new List<string>()
        {
            "python",
            "javasccript"
        };

    string resposta = "";
    List<char> palpite = new List<char>();
    int errors = 0;
    int maximoErros = 6;
    #endregion


    #region UI Properties

    public string Destaque
    {
        get => destaque;

        set
        {
            destaque = value;
            OnPropertyChanged();
        }
    }

    public List<char> Letras
    {
        get => letras;

        set
        {
            letras = value;
            OnPropertyChanged();
        }
    }

    public string Mensagem
    {
        get => mensagem;

        set
        {
            mensagem = value;
            OnPropertyChanged();
        }
    }

    public string StatusJogo
    {
        get => statusJogo;

        set
        {
            statusJogo = value;
            OnPropertyChanged();
        }
    }

    public string ImagemAtual
    {
        get => imagemAtual;

        set
        {
            imagemAtual = value;
            OnPropertyChanged();
        }
    }
    #endregion
    public JogoDeForca()
    {
        InitializeComponent();
        Letras = new List<char>();
        Letras.AddRange("abcdefghijklmnopqrstuvwxyz");
        BindingContext = this;
        EscolherPalavra();
        CalcularPalavra(resposta, palpite);
    }
    #region
    private void EscolherPalavra()
    {
        resposta = palavras[new Random().Next(0, palavras.Count)];
        Debug.WriteLine(resposta);
    }

    private void CalcularPalavra(string resposta, List<char> palpite)
    {
        var temp = resposta.Select(x => (palpite.IndexOf(x) >= 0 ? x : '_')).ToArray();

        Destaque = string.Join(' ', temp);
    }

    private void TratarPalpite(char letra)
    {
        if (palpite.IndexOf(letra) == -1)
        {
            palpite.Add(letra);
        }
        if (resposta.IndexOf(letra) >= 0)
        {
            CalcularPalavra(resposta, palpite);
            VerificaSeGanhou();
        }
        else if (resposta.IndexOf(letra) == -1)//erro
        {
            errors++;
            AtualizaStatus();
            VerificaSePerdeu();
            ImagemAtual = $"img{errors}.png";
        }
    }

    private void AtualizaStatus()
    {
        StatusJogo = $"Erros: {errors} de {maximoErros}";
    }

    private void VerificaSePerdeu()
    {
        if (errors == maximoErros)
        {
            Mensagem = "Você Perdeu!!";
            DesabilitarLetras();
        }
    }

    private void DesabilitarLetras()
    {
        foreach (var children in LetrasContainer.Children)
        {
            var btn = children as Button;
            if (btn != null)
            {
                btn.IsEnabled = false;
            }
        }
    }

    private void HabilitarLetras()
    {
        foreach (var children in LetrasContainer.Children)
        {
            var btn = children as Button;
            if (btn != null)
            {
                btn.IsEnabled = true;
            }
        }
    }


    private void VerificaSeGanhou()
    {
        if (Destaque.Replace(" ", "") == resposta)
        {
            Mensagem = "Você Ganhou!";
            DesabilitarLetras();
        }
    }
    private void Button_Clicked(object sender, EventArgs e)
    {
        maximoErros = 0;
        palpite = new List<char>();
        ImagemAtual = "img0.jpg";
        EscolherPalavra();
        CalcularPalavra(resposta, palpite);
        Mensagem = "";
        AtualizaStatus();
        HabilitarLetras();
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        var btn = sender as Button;
        if (btn != null)
        {
            var letra = btn.Text;
            btn.IsEnabled = false;
            TratarPalpite(letra[0]);
        }
    }

    //private void Reset_Clicked(object sender, EventArgs e)
    //{

    //}
}
#endregion