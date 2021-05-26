using System;
using System.Collections.Generic;
using System.Text;

namespace PBL3REAL.ViewModel
{
    class BookingVM
    {
        public int Index { get; set; }
        public int IdBook { get; set; }
        public string BookCode { get; set; }
        public DateTime BookBookdate { get; set; }
        public DateTime BookDuedate { get; set; }
        public DateTime BookCheckindate { get; set; }
        public DateTime BookCheckoutdate { get; set; }
       
        public string BookStatus { get; set; }
        public string BookNote { get; set; }
        public int BookDeposit { get; set; }
        public int BookTotalprice { get; set; }
        public string UserCode { get; set; }
        public string CliCode { get; set; }

    }
}
