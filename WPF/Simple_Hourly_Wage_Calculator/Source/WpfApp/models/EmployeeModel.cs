using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfApp.models
{
    class EmployeeModel
    {
        #region [ Properties ]

        public string Name { get; set; }
        public double hoursWorked { get; set; }
        public double hourlyPay { get; set; }

        #endregion [ Properties ]
       
        #region [ Constructor ]

        public EmployeeModel() { }
        public EmployeeModel(string eName,
                             double hrwk,
                             double hrpay)
        {
            Name = eName;
            hoursWorked = hrwk;
            hourlyPay = hrpay;
        }
        #endregion [ Constructor ]


        #region [ Methods ]
        
        public override string ToString()
        
        {
            string outputStr =
             string.Format(
             "{0} , you worked {1} hours @ {2:c} per hour. Your pay is {4:c}.",
             Name,
             hoursWorked,
             hourlyPay,
             Environment.NewLine,
             hoursWorked * hourlyPay);
            return outputStr;

            
        }


        #endregion [ Methods ]


    }
}
