using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Validation;


namespace Projet_finale_math
{
    public partial class Main : Form
    {
        public Main()
        { 
            InitializeComponent();
        }

        void INIT_UI()
        {
            textBox_REPONSE.ReadOnly = true;
            FORMULE_1.Select();
            textBox_Y_MIN.Text = "0";
            textBox_Y_MAX.Text = "11";
            
        }

        private void Main_Load(object sender, EventArgs e)
        {
            INIT_UI();
            ValidationProvider validationprovider = new ValidationProvider(this);
            validationprovider.AddControlToValidate(textBox_Y_MIN,Validate_TBX_Y_MIN);
            validationprovider.AddControlToValidate(textBox_Y_MAX, Validate_TBX_Y_MAX);
           
        }


               private void calculer()
        {
            if(FORMULE_1.Checked)
            {
                double reponseformmule1;
                int x;

                reponseformmule1 = -1 * Math.Pow((x * x) - (16 * x) + 4, -1.0 / 3);


            }
            if (FORMULE_2.Checked)
            {
                double reponseformmule2;
                int x;

                reponseformmule2 = 3 * Math.Pow((x- 7 / 5), 5) - 5 * Math.Pow((x - 7 / 5), 3) + 3
            }
            if (FORMULE_3.Checked)
            {
                double reponseformmule3;
                int x;

                reponseformmule3 = -(1 / 3) * Math.Pow((x - 6), 2) + 12;
            }
            if (FORMULE_4.Checked)
            {
                double reponseformmule4;
                int x;

                reponseformmule4 = x + Math.Sin(x);
            }
            if (FORMULE_5.Checked)
            {
                double reponseformmule5;
                int x;

                reponseformmule5 = Math.Cos(x) + 3;
            }
        }







        #region validation
        public static bool IsValid(string str)
        {
            int i;
            return int.TryParse(str, out i) && i >= 0 && i <= 11;
        }



        bool Validate_TBX_Y_MIN(ref string message)
        {
            bool value = true;
            if (textBox_Y_MAX.Text == "")
            {
                message = "champ vide";
            }
            else 
            {
                value = IsValid(textBox_Y_MIN.Text);
                message = "parametre hors bornes: 0 - 11";
            }

            return textBox_Y_MAX.Text != "" && value;
        }

        bool Validate_TBX_Y_MAX(ref string message)
        {
            bool value = true;
            if (textBox_Y_MAX.Text == "")
            {
                message = "champ vide";
            }
            else
            {
                value = IsValid(textBox_Y_MAX.Text);
                message = "parametre hors bornes: 0 - 11";
            }

            return textBox_Y_MAX.Text != "" && value;
        }

       
        #endregion

        private void BTN_CALCULER_Click(object sender, EventArgs e)
        {

        }

        private void BTN_CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        #region keypress
        //sert a faire en sorte que les champs d'entrer prenne seulement les chiffres et un seul point ou virgule.
        private void textBox_Y_MIN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox_Y_MAX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
         (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        

        private void textBox_X_MIN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
         (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox_X_MAX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        #endregion
    }
}
