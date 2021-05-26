using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagement.ViewModel
{
   public class RoomDetailVM
    {
        public RoomDetailVM()
        {
           /* MapRoomtype = new Dictionary<int, string>();*/
            ListStatusTime = new List<StatusTimeVM>();
        }
        public int IdRoom { get; set; }
        public string RoomName { get; set; }
        public string RoomDescription { get; set; }
        public decimal RotyCurrentprice { get; set; }
        public string RoTyName { get; set; }

        public int IdRoomType { get; set; }

        /*public IDictionary<int, string> MapRoomtype { get; set; }*/
        public List<StatusTimeVM>ListStatusTime { get; set; }
    }
}

