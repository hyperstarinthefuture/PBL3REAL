using System;
using System.Collections.Generic;
using System.Text;

namespace PBL3REAL.ViewModel
{
    public class UserVM
    {
        public UserVM()
        {
            ListRole = new List<RoleVM>();
            ListImg = new List<ImageVM>();
        }
        public int IdUser { get; set; }
        public string UserName { get; set; }
        public string UserGmail { get; set; }
        public string UserPhone { get; set; }
        public bool UserGender { get; set; }
        public bool UserActiveflag { get; set; }
        public string UserCode { get; set; }
        public string UserPassword { get; set; }
        public List<RoleVM>ListRole { get; set; }
        public List<ImageVM>ListImg { get; set; }
       
    }
}
