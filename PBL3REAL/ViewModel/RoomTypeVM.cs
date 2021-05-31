using PBL3REAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagement.ViewModel
{
    public class RoomTypeVM
    {
        public RoomTypeVM()
        {
            ListImg = new List<ImageVM>();
           /* MapImgUrl = new Dictionary<int, string>();*/
        }
        public int IdRoomtype { get; set; }
        public string RotyName { get; set; }
        public string RotyDescription { get; set; }
        public int RotyCurrentprice { get; set; }
        public int RotyCapacity { get; set; }
        public bool RoTyActiveflag { get; set; }
        public string RotyCode { get; set; }

        /* public IDictionary<int, string> MapImgUrl { get; set; }*/
        public List<ImageVM> ListImg { get; set; }
    }
}
