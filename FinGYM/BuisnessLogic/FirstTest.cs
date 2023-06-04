using FinGYM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FinGYM.BuisnessLogic
{
    public class FirstTest
    {
        Datacontext datacontext;
        int number;
        string s = "";
        public FirstTest()
        {
            datacontext = new Datacontext();


        }


        #region CheckYesOrnot function
        public bool CheckYesOrnot()
        {
            bool res = false;
            string messa = "Are you Sure ?";
            string title = "Close Window";
            MessageBoxButtons bb = MessageBoxButtons.YesNo;
            DialogResult rest = MessageBox.Show(messa, title, bb);
            if (rest == DialogResult.Yes)
            {
                res = true;
            }
            return res;
        }
        #endregion
        ///////////////////////////////////////////////////////


        #region Login function
        public string Login(string name, string pass)
        {
            string res = "";
            if (name == "" || pass == "")
            {
                res = "You have to Enter Passoword And UserName";
            }
            else
            {
                var Users = datacontext.Mangers.Select(user => user);
                foreach (var item in Users)
                {
                    if (item.UserName == name && item.PassWord == pass)
                    {
                        res = "Found";
                        break;

                    }
                    else
                    {
                        res = "Wrong password or UserName";
                    }
                }

            }

            return res;
        }

        #endregion
        /// ////////////////////////////////////////////////////////////////

        #region Class Functions
        public string ClasstName(string Claname)
        {
            string res = "";


            var objects = datacontext.Classes.Select(d => d.name).ToList();
            if (Claname == "" || int.TryParse(Claname, out number))
            {
                res = "Not Accepted Name or is Already Existe";
            }
            else if (objects.Contains(Claname))
            {
                res = $"{Claname} is Already Existe";
            }
            else
            {
                res = "Done";
            }
            return res;
        }

        #endregion
        /// /////////////////////////////////////////////////////////////

        #region Change Password Functions
        public string ChangePass(string userName, string Oldpass, string Newpass, string ConfirmPass)
        {
            string res = "";
            if (userName == "" || Oldpass == "" || Newpass == "" || ConfirmPass == "")
            {
                res = "You have to enter all Information";
            }
            else
            {
                var Users = datacontext.Mangers.Select(user => user).ToList();
                foreach (var item in Users)
                {
                    if (item.UserName == userName && item.PassWord == Oldpass)
                    {
                        if (Newpass == ConfirmPass)
                        {
                            res = "Done";
                            break;
                        }
                        else
                        {
                            res = "Password is not identical";
                        }
                    }
                    else
                    {
                        res = "There is no such Manger";
                    }
                }
            }
            return res;
        }
        #endregion
        ///////////////////////////////////////////////////////////////////


        #region Add Manger 
        public string AddManger(string name, string pass)
        {

            string res = "";


            var objects = datacontext.Mangers.Select(d => d.UserName).ToList();
            if (name == "" || pass =="" || int.TryParse(name, out number))
            {
                res = "Please Enter All Information ";
            }
            else if (objects.Contains(name))
            {
                res = $"{name} is Already Existe";
            }
            else
            {
                res = "Done";
            }
            return res;
        }

        #endregion

        #region Update Object Name
        public string UpdateName(string Claname)
        {
            string res = "";
            int number;
            if (Claname == "" || int.TryParse(Claname, out number))
            {
                res = "Not Accepted Name";
            }
            else
            {
                res = "Done";
            }
            return res;
        }

        #endregion

        #region Update Object age

        public string UpdateAge(int newAge)
        {
            string result = "";
            if (newAge > 18 && newAge != null)
            {
                result = "Done";
            }
            else
            {
                result = "Invalid age";
            }

            return result;
        }

        #endregion

        #region Update Object Phone

        public string UpdatePhone(string phoneNumber)
        {
            string result = "";

            if (string.IsNullOrEmpty(phoneNumber))
            {
                result = "Phone number should not be empty.";
            }
            else if (phoneNumber.Length != 11)
            {
                result = "Invalid phone number length.";
            }
            else
            {
                result = "Done";
            }

            return result;
        }

        #endregion

        #region Update Object Gender
        public string UpdateGender(string newGender)
        {
            string result = "";

            if (string.IsNullOrEmpty(newGender))
            {
                result = "Gender should not be empty.";
            }
            else
            {
                result = "Done";
            }

            return result;
        }
        #endregion

        #region Check salary
        public string Checksalary(double salary)
        {
            if (salary < 0 || salary == null)
                return "Please check The Salary less Than 0";
            else
                return "Done";
        }


        #endregion



        #region Choose Mang Name

        public bool CheckManName(string ManageName)
        {
            int number;
            if (ManageName == "" || int.TryParse(ManageName, out number))

            {
                return false;
            }
            return true;
        }
        #endregion



        #region Choose JoinDate
        public bool CheckDate(DateTime join)
        {
         
            if (join == null)
            {
                return false;
            }
            return true;
        }
        #endregion

        #region Choose Class Name
        public string CheckClassName(string className)
        {
            int number;
            string res = "";

            if (className == "" || int.TryParse(className, out number))
            {
                res = "Not accepted value";
            }
            else
            {
                res = "Done";
            }

            return res;
        }
        #endregion
    }
}
