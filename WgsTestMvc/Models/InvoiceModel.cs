using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace WgsTestMvc.Models
{
    public class InvoiceModel
    {
        [DisplayName("Sales Id")]
        public int SALES_ID { get; set; }
        [DisplayName("Courier Id")]
        public int COURIER_ID { get; set; }
        [DisplayName("Invoice No")]
        public string INVOICE_NO { get; set; }
        [DisplayName("Invoice Date")]
        public DateTime INVOICE_DATE { get; set; }
        [DisplayName("To")]
        public string TO { get; set; }
        [DisplayName("Ship To")]
        public string SHIP_TO { get; set; }
        [DisplayName("Payment Type")]
        public string PAYMENT_TYPE { get; set; }

    }
}