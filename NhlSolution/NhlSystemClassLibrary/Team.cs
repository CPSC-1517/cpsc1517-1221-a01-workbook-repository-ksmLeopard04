using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace NhlSystemClassLibrary
{
    public class Team
    {
        //Define fully implemented properties with a backing field for: Name, City , Arena
        private string _name;
        private string _city;
        private string _arena;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                //Validate new value is not blank and contains only letters a-z
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(value), "Name cannot be blank.");
                }
                _name = value.Trim(); //remove leading "  hello" and trailing "hello  " white spaces 
            }
        }

        public string City
        {
            get 
            { 
                return _city; 
            }
            set
            {
                _city = value;
            }
        }
        //Define auto-implemented properties for: Conference, Division
        public Conference2 Conference { get; set; }
        public division Division { get; set; }
        //Greedy constructor
        public Team (string Name, Conference2 Conference, division Division)
        {
            this.Name = Name;
            this.Conference = Conference;
            this.Division = Division;
        }

    }
}
