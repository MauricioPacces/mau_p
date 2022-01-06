using Models;
using RegradeNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TesteWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Incluir_Click(object sender, RoutedEventArgs e)
        {
            BlocoNegocio BN = new BlocoNegocio();
            Bloco bloco = new Bloco();
            bloco.Nome = "agnes";
            bloco.IdCondominios = 1;
            //BN.incluir(bloco);
        }

        private void Consultar_Click(object sender, RoutedEventArgs e)
        {
            BlocoNegocio BN = new BlocoNegocio();
            Bloco bloco = BN.consultar(1);
        }

        private void Atualizar_Click(object sender, RoutedEventArgs e)
        {
            BlocoNegocio BN = new BlocoNegocio();
            Bloco bloco = new Bloco();
            bloco.Id = 1;
            bloco.Nome = "Navarro";
            bloco.IdCondominios = 8;
            //BN.atualiza(bloco);
        }
        private void Deletar_Click(object sender, RoutedEventArgs e)
        {
            BlocoNegocio BN = new BlocoNegocio();
            BN.excluir(3);
        }

        private void ConsultaTodos_Click(object sender, RoutedEventArgs e)
        {
            BlocoNegocio BN = new BlocoNegocio();
            List<Bloco> ct = BN.consultarTodos();
        }
    }
}
