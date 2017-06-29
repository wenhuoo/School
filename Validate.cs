using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Validate
    {
        public Validate()
        {

        }

        public string valFName (string value)
        {
            string output = "";

            if (string.IsNullOrEmpty(value))
            {
                return output = "First Name cannot be Empty";
            }
            if (value.Length > 50)
            {
                return output = "First Name must be within 50 characters!";
            }
            return output;
        }

        public string valLName(string value)
        {
            string output = "";

            if (string.IsNullOrEmpty(value))
            {
                return output = "Last Name cannot be Empty";
            }
            if (value.Length > 50)
            {
                return output = "Last Name must be within 50 characters!";
            }
            return output;
        }

        public string valCName(string value)
        {
            string output = "";

            if (string.IsNullOrEmpty(value))
            {
                return output = "Course Name cannot be Empty";
            }
            if (value.Length > 50)
            {
                return output = "Course Name must be within 50 characters!";
            }
            return output;
        }

        public string valSem(string value)
        {
            string output = "";

            if (string.IsNullOrEmpty(value))
            {
                return output = "Semester cannot be Empty";
            }
            if (value.Length > 50)
            {
                return output = "Semester must be within 50 characters!";
            }
            return output;
        }

        public string valAdd1(string value)
        {
            string output = "";

            if (string.IsNullOrEmpty(value))
            {
                return output = "Address1 cannot be Empty";
            }
            if (value.Length > 50)
            {
                return output = "Address1 must be within 50 characters!";
            }
            return output;
        }

        public string valAdd2 (string value)
        {
            string output = "";
            
            if (value.Length > 50)
            {
                return output = "Address2 must be within 50 characters!";
            }
            return output;
        }

        public string valSub (string value)
        {
            string output = "";

            if (string.IsNullOrEmpty(value))
            {
                return output = "Suburb cannot be Empty";
            }
            if (value.Length > 50)
            {
                return output = "Suburb must be within 50 characters!";
            }
            return output;
        }

        public string valState (string value)
        {
            string output = "";

            if (string.IsNullOrEmpty(value))
            {
                return output = "State cannot be Empty";
            }
            if (value.Length > 50)
            {
                return output = "State must be within 50 characters!";
            }
            return output;
        }

        public string valRegoNo(string value)
        {
            string output = "";

            if (string.IsNullOrEmpty(value))
            {
                return output = "RegoNo cannot be Empty";
            }
            if (value.Length > 50)
            {
                return output = "RegoNo must be within 50 characters!";
            }
            return output;
        }

        public string valPassword(string value)
        {
            string output = "";

            if (string.IsNullOrEmpty(value))
            {
                return output = "Password cannot be Empty";
            }
            if (value.Length > 7)
            {
                return output = "Password must be within 7 characters!";
            }
            return output;
        }

        public string valPhone(string value)
        {
            string output = "";
            int i = checkInput(value);
            long no;
            bool isInt = long.TryParse(value, out no);

            if (string.IsNullOrEmpty(value))
            {
                return output = "Phone cannot be Empty";
            }
            if (!isInt)
            {
                return output = "Phone must be integer!";
            }
            if (value.Length != 10)
            {
                return output = "Phone must be 10 digits!";
            }
            return output;
        }

        public string valPostcode(string value)
        {
            string output = "";
            int i = checkInput(value);
            long no;
            bool isInt = long.TryParse(value, out no);

            if (string.IsNullOrEmpty(value))
            {
                return output = "Post code cannot be Empty";
            }
            if (!isInt)
            {
                return output = "Post code must be integer!";
            }
            if (value.Length != 4)
            {
                return output = "Post code must be 4 digits!";
            }
            return output;
        }

        public string valYear(string value)
        {
            string output = "";
            int i = checkInput(value);
            long no;
            bool isInt = long.TryParse(value, out no);

            if (string.IsNullOrEmpty(value))
            {
                return output = "Year cannot be Empty";
            }
            if (!isInt)
            {
                return output = "Year must be integer!";
            }
            if (value.Length != 1)
            {
                return output = "Year must be 1 digits!";
            }
            return output;
        }

        public string valMark(string value)
        {
            string output = "";
            int i = checkInput(value);
            long no;
            bool isInt = long.TryParse(value, out no);

            if (string.IsNullOrEmpty(value))
            {
                return output = "Mark cannot be Empty";
            }
            if (!isInt)
            {
                return output = "Mark must be integer!";
            }
            if (!(no <= 100 && no >= 0))
            {
                return output = "Mark must be within 0 to 100!";
            }
            return output;
        }
        private int checkInput(string name)
        {
            switch (name)
            {
                case "First Name":
                case "Last Name":
                case "Course Name":
                case "Semester":
                case "Address1":
                case "Address2":
                case "Suburb":
                case "State":
                case "RegoNo":
                    {
                        return 50;
                    }
                case "Password":
                    {
                        return 7;
                    }
                case "Postcode":
                    {
                        return 4;
                    }
                case "Phone":
                    {
                        return 10;
                    }
                case "Year":
                    {
                        return 1;
                    }
                case "Mark":
                    {
                        return 100;
                    }
                default:
                    return 0;
            }
        }

        public String valString(string value, string name)
        {
            string output = "";
            int i = checkInput(name);
            long no;
            bool isInt = long.TryParse(value, out no);

            if (string.IsNullOrEmpty(value))
            {
                return output = name + " cannot be empty!";
            }
            if ((i == 50) || (i == 7))
            {
                if (value.Length > i)
                    return output = "Invalid Input. " + name + " must be within " + i.ToString() + "characters!";
            }
            else
            {

                if (!isInt)
                    return output = "Invalid. " + name + " must be integer!";
                if ((i == 4) || (i == 10))
                {
                    if (!(value.Length == i))
                    {
                        return output = name + " must be " + i.ToString() + " digits!";
                    }
                }
                if (i == 100)
                {
                    if (!(no >= 0 && no <= 100))
                    {
                        return output = name + " must be within 0 to 100!";
                    }
                }
            }

            return output;
        }

        public string validDateStart(DateTime d)
        {
            string output = "";
            int result = DateTime.Compare(DateTime.Today, d);
            if (result > 0)
            {
                output = "Date of birth cannot be before today!";
            }
            return output;
        }

        public string validDateDOB(DateTime d)
        {
            string output = "";
            int result = DateTime.Compare(d, DateTime.Today);
            if (result > 0)
            {
                output = "Date of birth cannot be in the future!";
            }
            return output;
        }

        public string validCID(string s)
        {
            using (SchoolEntities db = new SchoolEntities())
            {
                string output = "";
                int value;
                bool CIDisInt = int.TryParse(s, out value);
                var list = (from c in db.Courses where c.CID == value select c).FirstOrDefault();

                if (string.IsNullOrEmpty(s))
                {
                    return output = "Course ID cannot be Empty!";
                }

                if (!CIDisInt)
                {
                    return output = "Course ID must be Interger!";
                }

                if (list != null)
                {
                    return output = "ID exists already. Please check!";
                }

                return output;
            }
        }
    }
}
