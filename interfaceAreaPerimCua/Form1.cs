using static interfaceAreaPerimCua.Form1;

namespace interfaceAreaPerimCua
{
    public partial class Form1 : Form
    {
        private Square square;
        public Form1()
        {
            InitializeComponent();
        }

        public interface IShape
        {
            double CalculateArea();
            double CalculatePerimeter();
        }

        // Clase que representa un cuadrado y que implementa la interfaz IShape
        public class Square : IShape
        {
            public double SideLength { get; set; }

            public Square(double sideLength)
            {
                SideLength = sideLength;
            }

            public double CalculateArea()
            {
                return SideLength * SideLength;
            }

            public double CalculatePerimeter()
            {
                return 4 * SideLength;
            }
        }

      



        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtSideLength.Text, out double sideLength))
            {
                // Crear una instancia de Square con el valor del lado proporcionado
                square = new Square(sideLength);

                // Calcular el área y el perímetro del cuadrado
                double area = square.CalculateArea();
                double perimeter = square.CalculatePerimeter();

                // Mostrar los resultados en los cuadros de texto correspondientes
                txtArea.Text = area.ToString();
                txtPerimeter.Text = perimeter.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número válido para el lado del cuadrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
