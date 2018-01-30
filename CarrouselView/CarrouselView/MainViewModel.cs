using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace CarrouselView
{
    public class MainViewModel : BaseViewModel
    {
        public ObservableCollection<Modelo> Modelos { get; private set; } = new ObservableCollection<Modelo>();

        public MainViewModel()
        {
            Inicializar();
        }

        private void Inicializar()
        {
            Modelos.Add(new Modelo { Texto = "Texto Um", CorDeFundo = Color.Black, TemBotao = false });
            Modelos.Add(new Modelo { Texto = "Texto Dois", CorDeFundo = Color.Red, TemBotao = false });
            Modelos.Add(new Modelo { Texto = "Texto Tres", CorDeFundo = Color.Green, TemBotao = true });
        }
    }
}