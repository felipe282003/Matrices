using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Dibujar();
        }

        private Label CrearLabel (int i, int j, int value)
        {
            Label l = new Label();
            l.Height = A;
            l.Width = A;
            l.Top = i*A;
            l.Left = j*A;
            l.AutoSize = false;
            l.Text = value.ToString();
            switch (value) 
            {
                case 1: 
                l.BackColor= Color.Red;
                break;
                case 2:
                l.BackColor = Color.Green;
                break;
            }
            return l;
        }

        int[,] M =
        {
            {0,0,1,2},
            {0,0,1,0},
            {0,0,1,0},
            {0,0,0,0},
        };
        const int A = 20;
        const int size = 4;
        Point actual = new Point(3, 0);
        
         private void Dibujar()
        {
            this.Controls.Clear();
            for (int j = 0; j < size; j++)
            {
                for (int i = 0; i < size; i++)
                {
                    this.Controls.Add( CrearLabel(i, j, M[i,j]));
                }
            }
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
