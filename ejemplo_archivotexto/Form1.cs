using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ejemplo_archivotexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Guardar(string nombreArchivo, string texto)
        {
            //utilizar a veces append o open.or.create
            FileStream flujo = new FileStream(nombreArchivo, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter escritor = new StreamWriter(flujo);
            escritor.WriteLine(texto);
            escritor.Close();
        }
        private void buttonguardar_Click(object sender, EventArgs e)
        {
            Guardar("archivo.txt", textBox1.Text);
            MessageBox.Show("El texto ha sido guardado");
        }

        private void buttonleer_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = @"c:\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt| Todos los archivos (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string nombreArchivo = openFileDialog1.FileName;

                FileStream flujo = new FileStream(nombreArchivo, FileMode.Open, FileAccess.Read);
                StreamReader lector = new StreamReader(flujo);

                while (lector.Peek() > -1)
                {
                    string textoleido = lector.ReadLine();
                    richTextBox1.AppendText(textoleido);
                }
                lector.Close();
                }
            }

        private void buttonLeerDirecto_Click(object sender, EventArgs e)
        {
            string nombreArchivo = @"C:\Users\aemendez\source\repos\ejemplo_archivotexto\ejemplo_archivotexto\bin\Debug\archivo.txt";

            FileStream flujo = new FileStream(nombreArchivo, FileMode.Open, FileAccess.Read);
            StreamReader lector = new StreamReader(flujo);

            while (lector.Peek() > -1)
            {
                string textoleido = lector.ReadLine();
                richTextBox1.AppendText(textoleido);
            }
            lector.Close();
        }
    }
}
