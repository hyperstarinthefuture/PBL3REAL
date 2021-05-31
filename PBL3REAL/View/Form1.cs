using HotelManagement.BBL.Implement;
using HotelManagement.BLL.Implement;
using HotelManagement.DAL.Implement;
using HotelManagement.ViewModel;
using Newtonsoft.Json;
using PBL3REAL.BLL;
using PBL3REAL.DAL;
using PBL3REAL.Model;
using PBL3REAL.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3REAL
{
    public partial class Form1 : Form
    {
        private RoomTypeBLL roomTypeBLL;
        private RoomBLL roomBLL;
        private QLBookingBLL bookingBLL;
        private ClientDAL clientDAL;
        private ClientBLL clientBLL;
        private QLUserBLL userBLL;
        private RoomDAL roomDAL;
        private QLInvoiceBLL qLInvoiceBLL;
        public Form1()
        {
            InitializeComponent();
            roomTypeBLL = new RoomTypeBLL();
            roomBLL = new RoomBLL();
            bookingBLL = new QLBookingBLL();
            clientDAL = new ClientDAL();
            clientBLL = new ClientBLL();
            userBLL = new QLUserBLL();
            roomDAL = new RoomDAL();
            qLInvoiceBLL = new QLInvoiceBLL();
            PaginationRoom();
            //   findidRoom();
            // addRoomType();
            // deleteRoomType();
            /*editRoomType();*/
        //     showClient();
         //   testCBBRoom();

            /* Booking */
             // showBookingDetail();
            //      addBooking();
            // delBooking();
            //completeBooking();
            // addClient();

            /* User */
            //showUser();
            //   addUser();
            //    checkUser();
            //  updateUser();
            //delUser();
            //   showDetailUser();

            //  Test(); 
            //   cbbForRole();

            //   updateBooking1();
        }

        public void Test()
        {
            Invoice listVM =InvoiceDAL.Instance.findById(1);
            string json = JsonConvert.SerializeObject(listVM, Formatting.Indented);
            richTextBox1.Text = json;
        }

        //  PHAN USER (ADMIN ,RECEPTIONIST,...)

        //show tat ca cac quyen cua User
        public void cbbForRole()
        {
            comboBox2.DataSource = userBLL.getRoleForUser();
            comboBox2.DisplayMember = "RoleName";
        }
        
        //show tat ca user
        public void showUser()
        {
            List<UserVM> listVM = userBLL.getAll();
            string json = JsonConvert.SerializeObject(listVM, Formatting.Indented);
            richTextBox1.Text = json;
        }
        public void delUser()
        {
            userBLL.delUser(2);
        }
        public void showDetailUser()
        {
            UserVM userVM = userBLL.findDetailUser(2);
            string json = JsonConvert.SerializeObject(userVM, Formatting.Indented);
            richTextBox1.Text = json;
        }
        public void checkUser()
        {
            Dictionary<string, string> properties = new Dictionary<string, string>();
            properties.Add("code", "PVC20001");
            properties.Add("password", "phanvancg2001");
            UserVM userVM = userBLL.checkUser(properties);
            string json = JsonConvert.SerializeObject(userVM, Formatting.Indented);
            richTextBox1.Text = json;
        }

        public void updateUser()
        {
            UserVM userVM = userBLL.findDetailUser(2);
            RoleVM roleVM1 = new RoleVM
            {
                IdRole = 2
            };
            RoleVM roleVM2 = new RoleVM
            {
                IdRole = 3
            };
            userVM.ListRole.Add(roleVM1);
            userVM.ListRole.Add(roleVM2);
            userBLL.updateUser(userVM,null);
        }
        public void addUser()
        {
            UserVM userVM = userBLL.getAll()[0];
            userVM.IdUser = 0;
            userVM.UserCode = "PhanTest";
            userVM.ListRole.RemoveAt(0);
            userVM.ListImg.Clear();
            ImageVM imageVM = new ImageVM
            {
                ImgstoUrl = "/home/cuong/pro/vip/dangcap"
            };
            userVM.ListImg.Add(imageVM);
            userBLL.addUser(userVM);
        }
      

        //  PHAN CLIENT
        public void showClient()
        {
            List<Client> listVM = clientDAL.getAll();
            string json = JsonConvert.SerializeObject(listVM, Formatting.Indented);
            richTextBox1.Text = json;
        }
        public void addClient()
        {
            ClientVM clientVM = new ClientVM
            {
                CliCode = "asdfgqwe",
                CliGmail = "cuonggggggg@",
                CliName = "Hello",
                CliPhone = "0912345678"
            };
         
            clientBLL.add(clientVM);
        }

        ///     PHAN BOOKING

        ///tk nay se goi khi client ts lay phong khach san ,luc do le tan bam nut check --->hoan tat thu tuc booking
        ///Luu y khi complete xong thi ko con chuc nang update nx (unable di)
        public void completeBooking()
        {
            bookingBLL.completeBooking(2);
        }

        public void delBooking()
        {
            try
            {
                bookingBLL.delBooking(19,"Finish");
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
         
        }

        //Truong hop no ko thay doi fromDate va toDate
        public void updateBooking()
        {
            List<int> listOld = new List<int>();
            List<int> listdel = new List<int>();
            SubBookingDetailVM sub1 = new SubBookingDetailVM
            {
                BooDetNote = "Helllworllddddd",
                BoodetPrice = 1000000,
                BoodetIdroom = 3,
                BoodetRoTyCode = "TYP00004" 
            };
            listdel.Add(7);
            listdel.Add(8);
            BookingDetailVM bookingDetailVM = bookingBLL.getDetail(1);
            bookingDetailVM.BookNote = "ProYesssVip";
            bookingDetailVM.ListSub.Add(sub1);
            bookingBLL.updateBooking(bookingDetailVM, listdel, listOld);
        }

        //truong hop thay doi fromDate va toDate
        public void updateBooking1()
        {
            List<int> listOld = new List<int>();
            List<int> listdel = new List<int>();
            BookingDetailVM bookingDetailVM = bookingBLL.getDetail(1);
            bookingDetailVM.BookNote = "ProYesssVip";
            bookingDetailVM.BookCheckindate = Convert.ToDateTime("2021-03-18");
            bookingDetailVM.BookCheckoutdate = Convert.ToDateTime("2021-03-25");
            //b1 luu tat ca id cua SubBookingDetailVm qua listOld
            foreach (SubBookingDetailVM val in bookingDetailVM.ListSub)
            {
                listOld.Add(val.IdBoodet);
            }
            //b2 Xoa het tat ca SubBookingDetailVm
            bookingDetailVM.ListSub.Clear();
            //b3 them SubBookingDetailVm ms vao
            SubBookingDetailVM sub1 = new SubBookingDetailVM
            {
                BooDetNote = "TestUpdate",
                BoodetPrice = 2000000,
                BoodetIdroom = 3,
                BoodetRoTyCode = "TYP00004"
            };

            bookingDetailVM.ListSub.Add(sub1);
            bookingBLL.updateBooking(bookingDetailVM, null, listOld);
        }
        public void addBooking()
        {
            SubBookingDetailVM sub = new SubBookingDetailVM
            {
                BooDetNote = "None",
                BoodetPrice =1000000,
                BoodetIdroom =1,
                BoodetRoTyCode = "TYP00002"
            };
            
            BookingDetailVM result = new BookingDetailVM
            {
                BookNote = "Ko bk",
                BookCheckindate = DateTime.Now,
                BookCheckoutdate = DateTime.Now,
                BookBookdate = DateTime.Now,
                BookStatus = "Proccess",
                BookTotalprice = 10000000,
                BookDeposit = 20000,
                clientVM = new ClientVM
                {
                    CliCode = "PROVIP01",
                    CliName = "dadsa",
                    CliGmail = "dasdasdas",
                    CliPhone = "0981234567"
                }
            };
            result.ListSub.Add(sub);
            bookingBLL.addBooking(result);
        }

        //cai ni dung de show bang chi tiet cua booking 
        public void showBookingDetail()
        {
           BookingDetailVM result = bookingBLL.getDetail(2);
            string json = JsonConvert.SerializeObject(result, Formatting.Indented);
            richTextBox1.Text = json;
        }

        //cai ni show ra tat ca booking cho dataGridView
       /* public void showBooking()
        {
            List<BookingVM> listVM = bookingBLL.getAll();
            string json = JsonConvert.SerializeObject(listVM, Formatting.Indented);
            richTextBox1.Text = json;
        }*/

        //2 cai combobox ni cho roomtype va room ,o day combobox ta truyen vao RoomTypeVM va RoomVM
        public void testCBB()
        {
            comboBox1.DataSource = roomTypeBLL.findByProperty("","");
            comboBox1.DisplayMember = "RotyName";
        }
        public void testCBBRoom()
        {

            comboBox2.DataSource = roomBLL.findAvailableRoom(1, Convert.ToDateTime("2021-03-01"), Convert.ToDateTime("2021-03-08"));
            comboBox2.DisplayMember = "RoomName";
        }


        ///     PHAN ROOMTYPE
        public void showroomtype()
        {
            List<RoomTypeVM> listVM = roomTypeBLL.findByProperty("","");
            string json = JsonConvert.SerializeObject(listVM, Formatting.Indented);
            richTextBox1.Text = json;
        }

        public void addRoomType()
        {
            RoomTypeVM roomTypeVM = new RoomTypeVM
            {
                RotyCapacity = 3,
                RotyCurrentprice = 10000,
                RotyDescription = "ko co",
                RotyName = "Cuongpor",
            };
            ImageVM image1 = new ImageVM
            {
                ImgstoUrl = "home/cuong/yessss"
            };
            roomTypeVM.ListImg.Add(image1);
            ImageVM image2 = new ImageVM
            {
                ImgstoUrl = "home/cuong/nooooo"
            };
            roomTypeVM.ListImg.Add(image2);
            roomTypeBLL.addRoomType(roomTypeVM);
        }
        public void editRoomType()
        {
            RoomTypeVM roomTypeVM = roomTypeBLL.findbyid(1);
            roomTypeVM.RotyCapacity = 4;
            List<int> listdel = new List<int>();
            ImageVM imageVM1 = roomTypeVM.ListImg[1];
            listdel.Add(imageVM1.IdImgsto);
            roomTypeVM.ListImg.Remove(imageVM1);
            ImageVM imageVM = new ImageVM
            {
                ImgstoUrl = "/home/cuong/oke"
            };
            roomTypeVM.ListImg.Add(imageVM);
            roomTypeBLL.editRoomType(roomTypeVM, listdel);
        }
        public void deleteRoomType()
        {
            roomTypeBLL.deleteRoomType(7);
        }


        //Phan Room
        public void addRoom()
        {
            RoomDetailVM roomDetailVM = new RoomDetailVM
            {
                RoomName = "Cuongpr",
                RotyCurrentprice = 2000000,
                RoomDescription = "ko co"
            };
           /* roomDetailVM.MapRoomtype.Add(1, "single room");*/
            StatusTimeVM statusTimeVM1 = new StatusTimeVM
            {
                StatimFromdate = DateTime.Now,
                StatimTodate = Convert.ToDateTime("01/10/2022"),
            };
            statusTimeVM1.statusVM = new StatusVM
            {
                IdStatus = 1
            };
            roomDetailVM.ListStatusTime.Add(statusTimeVM1);

            StatusTimeVM statusTimeVM2 = new StatusTimeVM
            {
                StatimFromdate = DateTime.Now,
                StatimTodate = Convert.ToDateTime("01/12/2021"),
            };
            statusTimeVM2.statusVM = new StatusVM
            {
                IdStatus = 2
            };
            roomDetailVM.ListStatusTime.Add(statusTimeVM2);
            roomBLL.addRoom(roomDetailVM);
        }
        public void findidRoom()
        {
            RoomDetailVM roomDetailVM = roomBLL.findByID(1);
            string json = JsonConvert.SerializeObject(roomDetailVM, Formatting.Indented);
            richTextBox1.Text = json;
        }
     /*   public void deleteRoom()
        {
            int id = 7;
            roomBLL.deleteRoom(id);
        }*/
        public void updateRoom()
        {
            RoomDetailVM roomDetailVM = roomBLL.findByID(1);
            roomDetailVM.RoomName = "PROROOOM";
            //edit status time
            roomDetailVM.ListStatusTime[1].StatimTodate = Convert.ToDateTime("01/10/2021");

            //add Status time
            /*  StatusVM statusVM = new StatusVM();
              statusVM.IdStatus = 1;
              StatusTimeVM statusTimeVM = new StatusTimeVM();
              //statusTimeVM.IdStatim = 4; //gia su minh sua lai thong tin tk status_time da co trong db
              statusTimeVM.StatimFromdate = DateTime.Now;
              statusTimeVM.StatimTodate = Convert.ToDateTime("12/12/2021");
              statusTimeVM.statusVM = statusVM;
              roomVM.ListStatusTime.Add(statusTimeVM);*/

            //del sattus time
            // List<int>listdel = new List<int>();
            // listdel.Add(3);
            roomBLL.editRoom(roomDetailVM, null);
        }
        public void showRoom()
        {
            List<RoomVM> listVM = roomBLL.findByProperty(1,2,0,"A10",0);
            string json = JsonConvert.SerializeObject(listVM, Formatting.Indented);
            richTextBox1.Text = json;
        }

        public void PaginationRoom()
        {
            textBox1.Text = roomBLL.getPagination(2,0,"",0).ToString();

        }
      

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = ((RoomTypeVM)comboBox1.SelectedItem).RotyCurrentprice.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string code = textBox2.Text;
            InvoiceVM invoiceVM = qLInvoiceBLL.infoAddInvoice(code);
            string json = JsonConvert.SerializeObject(invoiceVM, Formatting.Indented);
            richTextBox1.Text = json;

        }
    }
}
