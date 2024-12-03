using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeconstructingObjects
{
    public partial class DeconstructingSample
    {

            public void Run()
            {
                //Tuple
                var (firstName, lastName) = ("Fardis", "Bahry");
                Console.WriteLine($"First Name: {firstName}, Last Name: {lastName}");
            }

        }
    }
