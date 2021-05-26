using System;
using System.Collections.Generic;
using System.Text;

namespace PBL3REAL.ViewModel
{
    public class InvoiceVM
    {
        public InvoiceVM()
        {
            DicRoom = new Dictionary<string, decimal>();
        }
        public int IdInvoice { get; set; }
        public DateTime InvCreatedate { get; set; }
        public DateTime InvUpdatedate { get; set; }
        public string InvCode { get; set; }
        public int TotalPrice { get; set; }

   //     public int InvIdbook { get; set; }
        public DateTime BookCheckindate { get; set; }

        public DateTime BookChecoutdate { get; set; }
 //       public string BookCode { get; set; }

        /*   public int InvIdUser { get; set; }*/
        public string UserCode { get; set; }
        /*   public int InvIdClient { get; set; }*/
        public string CliCode { get; set; }
        public string CliName {get ; set ;}
        public string CliPhone { get; set; }
        

        public Dictionary<string , decimal> DicRoom { get; set; }

    }
}
