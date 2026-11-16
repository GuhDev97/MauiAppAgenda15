using MauiAppAgenda15.Models;

namespace MauiAppAgenda15.Views;

public partial class CadastroEvento : ContentPage
{
    public CadastroEvento()
    {
        InitializeComponent();
        dtpckInicio.MinimumDate = DateTime.Now;
        dtpckTermino.MinimumDate = DateTime.Now;
    } // <--- Certifica-te de que esta chaveta fecha o construtor!

    private async void OnCadastrarClicked(object? sender, EventArgs e)
    {
        try
        {
            if (dtpckTermino.Date < dtpckInicio.Date)
            {
                await DisplayAlertAsync("Erro", "A data de término não pode ser anterior à data de início.", "OK");
                return;
            }

            Evento evento = new Evento
            {
                Nome = entNome.Text ?? string.Empty,
                Local = entLocal.Text ?? string.Empty,
                DataInicio = (DateTime)dtpckInicio.Date,     // Força a conversão explícita
                DataTermino = (DateTime)dtpckTermino.Date, // Força a conversão explícita
                NumeroParticipantes = int.Parse(entParticipantes.Text),
                CustoPorParticipante = double.Parse(entCusto.Text)
            };

            await Navigation.PushAsync(new ResumoEvento(evento));
        }
        catch (Exception)
        {
            await DisplayAlertAsync("Erro", "Preencha todos os campos corretamente com valores numéricos válidos.", "OK");
        }
    }
} // <--- Fecha a classe