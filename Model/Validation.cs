using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental_Managment.Model
{
    public class Validation
    {
                                                        /*  */
                                                     /*        */
                                                   /*             */
                                                 /*                 */
            /*    This Function Is Only For *****  Phone Validation  ******      */
                                                 /*                 */
                                                    /*            */
                                                       /*       */
                                                          /* */

        public void SpecialCharacterNotAllowdButDigiAllow(KeyPressEventArgs e)
        {
            if ((!char.IsLetter(e.KeyChar) && char.IsDigit(e.KeyChar)) || e.KeyChar == (char)Keys.Back)
            {
                // These characters may pass
                e.Handled = false;
            }
            else
            {
                // Everything that is not a letter, nor a backspace nor a space will be blocked
                e.Handled = true;
            }
        }

        public void Phone11digits(object sender, KeyPressEventArgs e)
        {
            try
            {
                SpecialCharacterNotAllowdButDigiAllow(e);
                if (char.IsDigit(e.KeyChar))
                {

                    //Count the digits already in the text.  I'm using linq:
                    if ((sender as TextBox).Text.Count(Char.IsDigit) >= 11)
                    {
                        e.Handled = true;

                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       

        public bool checkPhone(string Phone, object sender, KeyPressEventArgs e)
        {
            
            bool isValid = false;
            var r = new Regex(Phone);
            if (r.IsMatch(Phone))
            {
                Phone11digits(sender,e);
                isValid = true;
            }
            return isValid;
        }



                                                            /*  */
                                                         /*         */
                                                       /*             */
                                                     /*                 */
                 /*    This Function Is Only For *****  Email Validation  ******    */
                                                    /*                 */
                                                       /*            */
                                                         /*       */
                                                            /* */



        public bool checkEmail(string email)
        {
            bool isValid = false;
            Regex r = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (r.IsMatch(email))
            {
                isValid = true;

            }
            return isValid;
        }







                                                                /*  */
                                                            /*         */
                                                          /*             */
                                                        /*                 */
                  /*    This Function Is Only For *****  Password Validation  ******    */
                                                         /*                 */
                                                           /*            */
                                                             /*       */
                                                                 /* */




        public bool checkPassword(string Password)
        {

            bool isValid = false;
            Regex r = new Regex(@"([A-Za-z0-9!@$%_]{8,})+");
            if (r.IsMatch(Password))
            {
                isValid = true;

            }

            return isValid;
        }





    }
}
