using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuradeDatos
{
    public partial class Form1 : Form
    {

        public class Tnodo
        {
            public Tnodo ant;
            public Tnodo sig;
            public int dato;
        }

        Tnodo nuevo;
        Tnodo aux;
        Tnodo Raiz;
        String g = "";
        public int i=0;
        public int u=0;
        
        public Form1()
        {
            InitializeComponent();
        }

        public void raiz(int x)
        {
            nuevo = new Tnodo();
            nuevo.ant = null;
            nuevo.sig = null;
            nuevo.dato = x;
            Raiz = nuevo;
            aux = nuevo;
            Console.WriteLine(nuevo.dato);
        }

        public void hijoIzq(int x)
        {
            nuevo = new Tnodo();
            nuevo.ant = null;
            nuevo.sig = null;
            nuevo.dato = x;
            aux.ant = nuevo;
            aux = Raiz;
            Console.WriteLine(nuevo.dato);
        }
        public void hijoDer(int x)
        {
            nuevo = new Tnodo();
            nuevo.ant = null;
            nuevo.sig = null;
            nuevo.dato = x;
            aux.sig = nuevo;
            aux = nuevo;
            Console.WriteLine(nuevo.dato);
        }


        public void imprimir()
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            raiz(1);
            hijoIzq(2);
            hijoDer(3);
            hijoIzq(4);
            
        }
    }
}
