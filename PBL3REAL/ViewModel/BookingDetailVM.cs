using System;
using System.Collections.Generic;
using System.Text;

namespace PBL3REAL.ViewModel
{
    class BookingDetailVM : BookingVM
    {
        public BookingDetailVM()
        {
            ListSub = new List<SubBookingDetailVM>();
        }
    
        public ClientVM clientVM { get; set; }
        public List<SubBookingDetailVM>ListSub { get; set; }
    }
}
