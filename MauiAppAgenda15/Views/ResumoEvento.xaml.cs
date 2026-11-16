using MauiAppAgenda15.Models;

namespace MauiAppAgenda15.Views;

public partial class ResumoEvento : ContentPage
{
    public ResumoEvento(Evento evento)
    {
        InitializeComponent();

        // Requisito: Atribuir o objeto ao BindingContext para popular a UI automaticamente
        BindingContext = evento;
    }

    private async void OnVoltarClicked(object? sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}