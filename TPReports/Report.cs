/*
 * Borkhalenko Oleg
 * borkhalenko@gmail.com
 * 03.11.17
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace TPReports {
    class Report {
        private decimal cashIn;
        private decimal cashOut;
        private decimal encashment;
        private decimal salesRevenue;
        private DateTime reportDate;
        private DateTime creationDate;
        private DateTime approveDate;

        public decimal CashIn {
            get {
                return cashIn;
            }
            set {
                CheckCash(value, "Error when assign CashIn in Report class. Cash value can't be less than 0.");
                cashIn = value;
            }
        }

        public decimal CashOut {
            get {
                return cashOut;
            }
            set {
                CheckCash(value, "Error when assign CashOut in Report class. Cash value can't be less than 0.");
                cashOut = value;
            }
        }

        public decimal Encashment {
            get {
                return encashment;
            }
            set {
                CheckCash(value, "Error when assign Encashment in Report class. Cash value can't be less than 0.");
                cashOut = value;
            }
        }

        public decimal SalesRevenue {
            get {
                return salesRevenue;
            }
            set {
                CheckCash(value, "Error when assign SalesRevenue in Report class. Cash value can't be less than 0.");
                cashOut = value;
            }
        }
 
        public DateTime ReportDate { get => reportDate; set => reportDate = value; }
        public DateTime CreationDate { get => creationDate; set => creationDate = value; }
        public DateTime ApproveDate { get => approveDate; set => approveDate = value; }

        public Report() {
            CreationDate = DateTime.Now;
        }

        private void CheckCash(decimal value, string errorMessage) {
            if (value < 0) {
                throw new InvalidOperationException(errorMessage);
            }
        }
    }
}
