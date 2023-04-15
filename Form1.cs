using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_ejemplo_1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(txtN1.Text);
            int numero2 = Convert.ToInt32(txtN2.Text);

            int suma = Sumar(numero1, numero2);
            int resta = Restar(numero1, numero2);
            int multiplicacion = Multiplicar(numero1, numero2);
            double division = Dividir(numero1, numero2);

            //cambios agregados por la rama soraya
            

            MessageBox.Show($"La Suma es: {suma}\n" +
                $"La Resta es: {resta}\n" +
                $"La Multiplicacion es: {multiplicacion}\n" +
                $"La Division es: {division}");
        }

        private double Dividir(int numero1, int numero2)
        {
            return numero1 / (double)numero2;
        }

        private int Multiplicar(int numero1, int numero2)
        {
            return numero1 * numero2;
        }
        
        //metodo restar documentado por soraya 
        private int Restar(int numero1, int numero2)
        {
            return numero1 - numero2;
        }

        //metodo Suma documentado
        private int Sumar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }
        
        private void btnPrimos_Click(object sender, EventArgs e)
        {
           //TODO Dado un rango de valores (numero1 - numero2), mostrar en 
           //es un mensaje (MessageBox.Show) los numeros primos dentro el trando
           
        }


    }
}
