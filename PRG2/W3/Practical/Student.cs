    class Student
    {
        //Question 1
        //Complete the missing attributes & Properties and the incomplete student class constructor

        // attributes and properties
        private string tel;

        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }

        private DateTime dateOfBirth;

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        // constructor
        public Student(string t, DateTime dob)
        {
            Tel = t;
            DateOfBirth = dob;
        }
    }