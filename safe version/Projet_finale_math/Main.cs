using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

            }
            if (FORMULE_2.Checked)
            {

            }
            if (FORMULE_3.Checked)
            {

            }
            if (FORMULE_4.Checked)
            {

            }
            if (FORMULE_5.Checked)
            {


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
