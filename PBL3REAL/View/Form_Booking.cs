using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PBL3REAL.BLL;
using PBL3REAL.ViewModel;
using PBL3REAL.Extention;
using HotelManagement.BBL.Implement;
using HotelManagement.BLL.Implement;
namespace PBL3REAL.View
{
    public partial class Form_Booking : Form
    {
        private QLBookingBLL BookingBLL;
        private RoomTypeBLL roomTypeBLL;
        private RoomBLL roomBLL;
        private ClientBLL clientBLL;
        private int IDBook = 0;
        private BookingDetailVM detailVM;
        private List<SubBookingDetailVM> subBookings;
        private List<RoomVM> roomVMs;
        private List<RoomVM> BookedRoomVMs;
        public Form_Booking(int IdBook, bool Editable)
        {
            InitializeComponent();
            BookingBLL = new QLBookingBLL();
            roomTypeBLL = new RoomTypeBLL();
            clientBLL = new ClientBLL();
            IDBook = IdBook;
            if (IdBook != 0)
            {
                detailVM = BookingBLL.getDetail(IDBook);
                LoadData(IdBook,Editable);
            }  
            else
            {
                //Generate IdBook để add
            }
            LoadRoomTypeList();
        }
        //Load Data Functions
        private void LoadRoomTypeList()
        {
            List<CbbItem> list = roomTypeBLL.addCombobox();
            List<CbbItem> res = list;
            cbb_RoomType.DataSource = res;
        }
        private void LoadBookedRoomList()
        {
            dgv.DataSource = detailVM.ListSub;
        }
        private void LoadAvailableTempRoomList()
        {
            cbb_Room.DataSource = null;
            cbb_Room.DataSource = roomVMs;
            cbb_Room.DisplayMember = "RoomName";
            cbb_Room.ValueMember = "IdRoom";
        }
        private void LoadAvailableRoomList(int IdRoomtype, DateTime fromDate, DateTime toDate)
        {
            roomVMs = roomBLL.findAvailableRoom(IdRoomtype, fromDate, toDate);
            LoadAvailableTempRoomList();
        }
        private void LoadData(int id, bool Edit)
        {
            if (id == 0)
            {
                //Add new booking
                tb_BookDate.Text = DateTime.Now.ToString();
                tb_DueDate.Text = (DateTime.Now.AddDays(5)).ToString();
            }
            else
            {
                //View or Edit
                //ClientVM temp3 = ClientBLL.
                //tb_ClientName.Text = temp2.;
                //tb_ClientAddress.Text = temp. ;
                //tb_ClientContact.Text = ;
                dtp_From.Value = detailVM.BookCheckindate;
                dtp_To.Value = detailVM.BookCheckoutdate;
                LoadBookedRoomList();
                tb_BookDate.Text = detailVM.BookBookdate.ToString();
                tb_DueDate.Text = detailVM.BookDuedate.ToString();
                tb_Deposit.Text = detailVM.BookDeposit.ToString();
                tb_Total.Text = detailVM.BookTotalprice.ToString();
                cbb_Status.Text = detailVM.BookStatus;
                tb_Note.Text = detailVM.BookNote;
            }
            if (!Edit)
            {
                grbx_ClientInfo.Enabled = false;
                grbx_PeriodTime.Enabled = false;
                grbx_BookingInfo.Enabled = false;
                picbx_Enter.Enabled = false;
                picbx_Add.Enabled = false;
                picbx_Delete.Enabled = false;
                btn_OK.Enabled = false;
                btn_Invoice.Enabled = false;
                btn_Checkin.Enabled = false;
                btn_Reset.Enabled = false;
            }
        }
        //Check Data Function
        private int CheckData()
        {
            if (tb_ClientName.Text == "" || tb_ClientContact.Text == "" || tb_ClientAddress.Text == "" 
                || tb_Deposit.Text == "" || cbb_Status.SelectedItem == null)
            { return 1; }   
            else if (dgv.Rows.Count == 0)
            { return 2; }    
            else
            { return 0; }    
        }
        //Booking Functions
        private void AddBooking()
        {
            //SubBookingDetailVM sub = new SubBookingDetailVM
            //{
            //    BooDetNote = "None",
            //    BoodetPrice = 1000000,
            //    BoodetIdroom = 1,
            //    BoodetRoTyCode = "TYP00002"
            //};

            BookingDetailVM result = new BookingDetailVM
            {
                BookNote = tb_Note.Text,
                BookCheckindate = dtp_From.Value,
                BookCheckoutdate = dtp_To.Value,
                BookBookdate = Convert.ToDateTime(tb_BookDate.Text),
                BookStatus = cbb_Status.Text.Replace(" ",String.Empty),
                BookTotalprice = Convert.ToInt32(tb_Total.Text),
                BookDeposit = Convert.ToInt32(tb_Deposit.Text),
                clientVM = new ClientVM
                {
                    CliName = "dadsa",

                    CliPhone = "0981234567"
                }
            };
            foreach (RoomVM item in BookedRoomVMs)
            {
                result.ListSub.Add(new SubBookingDetailVM
                {
                    BooDetNote = "",
                    BoodetPrice = Convert.ToInt32(item.RotyCurrentprice),
                    BoodetIdroom = item.IdRoom,
                    BoodetRoTyCode = cbb_RoomType.SelectedValue.ToString()
                });
            }
            //result.ListSub.Add(sub);
            BookingBLL.addBooking(result);
        }
        private void UpdateBooking(bool Changes)
        {
            List<int> listOld = new List<int>();
            List<int> listdel = new List<int>();
            
            if (Changes)
            {
                BookingDetailVM bookingDetailVM = BookingBLL.getDetail(1);
                bookingDetailVM.BookNote = tb_Note.Text;
                bookingDetailVM.BookCheckindate = dtp_From.Value;
                bookingDetailVM.BookCheckoutdate = dtp_To.Value;
                //b1 luu tat ca id cua SubBookingDetailVm qua listOld
                foreach (SubBookingDetailVM val in bookingDetailVM.ListSub)
                {
                    listOld.Add(val.IdBoodet);
                }
                //b2 Xoa het tat ca SubBookingDetailVm
                bookingDetailVM.ListSub.Clear();
                //b3 them SubBookingDetailVm ms vao
                //SubBookingDetailVM sub1 = new SubBookingDetailVM
                //{
                //    BooDetNote = dgv.SelectedRows[0].Cells["BooDetNote"].Value.ToString(),
                //    BoodetPrice = 2000000,
                //    BoodetIdroom = 3,
                //    BoodetRoTyCode = "TYP00004"
                //};

                //bookingDetailVM.ListSub.Add(sub1);
                foreach(RoomVM item in BookedRoomVMs)
                {
                    bookingDetailVM.ListSub.Add(new SubBookingDetailVM {
                        BooDetNote = "",
                        BoodetPrice = Convert.ToInt32(item.RotyCurrentprice),
                        BoodetIdroom = item.IdRoom,
                        BoodetRoTyCode = cbb_RoomType.SelectedValue.ToString()
                    });
                }    
                BookingBLL.updateBooking(bookingDetailVM, null, listOld);
            }
            else
            {
                //SubBookingDetailVM sub1 = new SubBookingDetailVM
                //{
                //    BooDetNote = "Helllworllddddd",
                //    BoodetPrice = 1000000,
                //    BoodetIdroom = 3,
                //    BoodetRoTyCode = "TYP00004"
                //};
                listdel.Add(7);
                listdel.Add(8);
                BookingDetailVM bookingDetailVM = BookingBLL.getDetail(1);
                bookingDetailVM.BookNote = tb_Note.Text;
                foreach (RoomVM item in BookedRoomVMs)
                {
                    bookingDetailVM.ListSub.Add(new SubBookingDetailVM
                    {
                        BooDetNote = "",
                        BoodetPrice = Convert.ToInt32(item.RotyCurrentprice),
                        BoodetIdroom = item.IdRoom,
                        BoodetRoTyCode = cbb_RoomType.SelectedValue.ToString()
                    });
                }
                BookingBLL.updateBooking(bookingDetailVM, listdel, listOld);
            }
        }
        //Events
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void picbx_Enter_Click(object sender, EventArgs e)
        {
            LoadAvailableRoomList(((CbbItem)cbb_RoomType.SelectedItem).Value,dtp_From.Value,dtp_To.Value);
        }
        private void picbx_Add_Click(object sender, EventArgs e)
        {
            //add room
            if (dtp_From.Value != null && dtp_To.Value != null && cbb_RoomType.SelectedItem != null)
            {
                foreach (RoomVM item in roomVMs)
                {
                    if (item.IdRoom == ((CbbItem)cbb_Room.SelectedItem).Value)
                    {
                        subBookings.Add( new SubBookingDetailVM
                        {
                            BooDetNote = item.RoomDescription,
                            BoodetPrice = Convert.ToInt32(item.RotyCurrentprice),
                            BoodetIdroom = item.IdRoom,
                            BoodetRoTyCode = cbb_RoomType.SelectedValue.ToString(),
                        });
                        BookedRoomVMs.Add(item);
                        roomVMs.Remove(item);
                        LoadBookedRoomList();
                        LoadAvailableTempRoomList();
                        break;
                    }    
                }
            }    
        }
        private void picbx_Delete_Click(object sender, EventArgs e)
        {
            //del room
            if (dgv.SelectedRows.Count == 1)
            {
                foreach(RoomVM item in BookedRoomVMs)
                {
                    if (item.IdRoom == int.Parse(dgv.SelectedRows[0].Cells["BoodetIdroom"].Value.ToString()))
                    {
                        roomVMs.Add(item);
                        subBookings.Remove(
                             new SubBookingDetailVM
                             {
                                 BooDetNote = item.RoomDescription,
                                 BoodetPrice = Convert.ToInt32(item.RotyCurrentprice),
                                 BoodetIdroom = item.IdRoom,
                                 BoodetRoTyCode = cbb_RoomType.SelectedValue.ToString(),
                             });
                        BookedRoomVMs.Remove(item);
                        LoadAvailableTempRoomList();
                        LoadBookedRoomList();
                        break;
                    }    
                }   
            }    
        }
        private void btn_OK_Click(object sender, EventArgs e)
        {
            switch(CheckData())
            {
                case 1:
                    MessageBox.Show("Bạn chưa nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                case 2:
                    MessageBox.Show("Bạn chưa chọn phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                default:
                    if (IDBook == 0)
                    {
                        AddBooking();
                        MessageBox.Show("Đã tạo thành công đơn booking mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (dtp_From.Value == detailVM.BookCheckindate && dtp_To.Value == detailVM.BookCheckoutdate)
                        {
                            UpdateBooking(false);
                        }    
                        else
                        {
                            UpdateBooking(true);
                        }
                        MessageBox.Show("Đã cập nhật thành công đơn booking!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
            }    
        }
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            //Reset data
        }
        private void btn_Checkin_Click(object sender, EventArgs e)
        {
            //Checkin
        }
        private void btn_Invoice_Click(object sender, EventArgs e)
        {
            //Export to invoice
        }
    }
}
