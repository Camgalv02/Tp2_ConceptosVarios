namespace Clase2ConceptosVarios
{
    public partial class Form1 : Form
    {
        public Form1()  //constructor
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnMostrarMensaje_Click(object sender, EventArgs e)
        {

            // MessageBox.Show("Mensaje", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            int n1 = 1;
            int n2 = 2;

            //MessageBox.Show("Antes: " + n1.ToString() + " - " + n2.ToString());

            int r1 = Sumar(ref n1, n2);
            int r2 = Sumar(1, 2, 3);
            int r3 = Sumar(1, 2, "cadena");

            //MessageBox.Show("Despues: " + n1.ToString() + " - " + n2.ToString());

            MessageBox.Show("Resultado :" + r2.ToString());

        }

        // metodo para sumar

        /*
            comentario 
            multilinea
         */

        /// <summary>
        /// ESTE METODO RECIBE DOS PARAMETROS Y RETORNA LA SUMA
        /// </summary>
        /// <param name="num1">NUMERO 1</param>
        /// <param name="num2">NUMERO 2</param>
        /// <returns></returns>
        public int Sumar(ref int num1, int num2)
        {
            num1 = 5;

            num2 = 10;

            int res = num1 + num2;

            return res;
        }

        //sobrecarga del metodo
        public int Sumar(int numero1, int num2, int num3)
        {
            numero1 = 5;

            num2 = 10;

            int res = numero1 + num2;

            return res;
        }

        //sobrecarga del metodo
        public int Sumar(int num1, int num2, string mensaje)
        {
            num1 = 5;

            num2 = 10;

            int res = num1 + num2;

            return res;
        }

    }
}
}