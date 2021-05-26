using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HotelManagement.BBL.Implement;
using HotelManagement.BLL.Implement;
using HotelManagement.ViewModel;
using PBL3REAL.BLL;
using PBL3REAL.Extention;
using PBL3REAL.ViewModel;
namespace HotelManagement.View
{
    public partial class Form_Detail_Room : Form
    {
        private int idRoom;
        private RoomBLL _roomBLL;
        private RoomTypeBLL _roomTypeBLL;
        private RoomDetailVM roomDetailVM;
        private List<int> listdel;
        public Form_Detail_Room(int idRoom, bool Editable)
        {
            InitializeComponent();
            this.idRoom = idRoom;
            _roomBLL = new RoomBLL();
            _roomTypeBLL = new RoomTypeBLL();
            comboboxRoomType();
            if (Editable) 
            { 
                comboboxStatus();
            }
            else
            {
                grbx_FromToStatus.Enabled = false;
                grbx_RoomInfo.Enabled = false;
                btn_OK.Enabled = false;
                btn_Reset.Enabled = false;
            }  
            if (idRoom != 0) LoadData();
            else roomDetailVM = new RoomDetailVM();
            listdel = new List<int>();
        }
        //Load data Functions
        private void comboboxRoomType()
        {
            List<CbbItem> res = _roomTypeBLL.addCombobox();
            cbb_RoomType.DataSource = res;
        }
        private void comboboxStatus()
        {
            List<CbbItem> res = _roomBLL.addComboboxStatus();
            cbb_RoomStatus.DataSource = res;
        }
        private void addDataGridView()
        {
            dgv.DataSource = null;
            dgv.DataSource = roomDetailVM.ListStatusTime;
            dgv.Columns["IdStatim"].Visible = false;
            dgv.Columns["statusVM"].Visible = false;
            dgv.Columns["IdStatus"].Visible = false;
        }
        private void LoadData()
        {
            roomDetailVM = _roomBLL.findByID(idRoom);
            tb_RoomName.Text = roomDetailVM.RoomName;
            tb_RoomDescription.Text = roomDetailVM.RoomDescription;
            addDataGridView();
            if (dgv.Columns["Status"] == null)
            {
                DataGridViewColumn newcol = new DataGridViewColumn();
                newcol.HeaderText = "Status";
                newcol.Name = "Status";
                DataGridViewCell cell = new DataGridViewTextBoxCell();
                cell.ValueType = typeof(string);
                newcol.CellTemplate = cell;
                newcol.Visible = true;
                dgv.Columns.Add(newcol);
            }
            int j = 0;
            foreach (StatusTimeVM statusTimeVM in roomDetailVM.ListStatusTime)
            {
                dgv.Rows[j].Cells["Status"].Value = statusTimeVM.statusVM.StaName;
            }
            for (int i = 0; i < cbb_RoomType.Items.Count; i++)
            {
                CbbItem cbbItem = (CbbItem)cbb_RoomType.Items[i];
                if (cbbItem.text == roomDetailVM.RoTyName)
                {
                    cbb_RoomType.SelectedIndex = i;
                    break;
                }
            }
        }
        //Reset Data
        private void ResetData()
        {

        }
        //Room Processing Functions
        private void AddRoom()
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
            _roomBLL.addRoom(roomDetailVM);
        }
        private void EditRoom()
        {
            RoomDetailVM roomDetailVM = _roomBLL.findByID(1);
            roomDetailVM.RoomName = "PROROOOM";
            //edit status time
            roomDetailVM.ListStatusTime[1].StatimTodate = Convert.ToDateTime("01/10/2021");
            //add Status time
            StatusVM statusVM = new StatusVM();
            statusVM.IdStatus = 1;
            StatusTimeVM statusTimeVM = new StatusTimeVM();
            statusTimeVM.IdStatim = 4; //gia su minh sua lai thong tin tk status_time da co trong db
            statusTimeVM.StatimFromdate = DateTime.Now;
            statusTimeVM.StatimTodate = Convert.ToDateTime("12/12/2021");
            statusTimeVM.statusVM = statusVM;
            //roomVM.ListStatusTime.Add(statusTimeVM);
            //del sattus time
            List<int> listdel = new List<int>();
            listdel.Add(3);
            _roomBLL.editRoom(roomDetailVM, null);
        }
        public void PaginationRoom()
        {
            tb_PageNumber.Text = _roomBLL.getPagination().ToString();
        }
        //Events
        private void btn_OK_Click(object sender, EventArgs e)
        {
            roomDetailVM.RoomName = tb_RoomName.Text;
            roomDetailVM.RoomDescription = tb_RoomDescription.Text;
            roomDetailVM.IdRoomType = ((CbbItem)cbb_RoomType.SelectedItem).Value;
            if (idRoom != 0)
            {
                _roomBLL.editRoom(roomDetailVM, listdel);
            }
            else
            {
                _roomBLL.addRoom(roomDetailVM);
            }
            this.Dispose();
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            //Reset data
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            StatusTimeVM statusTimeVM = new StatusTimeVM
            {
                StatimFromdate = dtp_From.Value,
                StatimTodate = dtp_To.Value,
                statusVM = new StatusVM()
            };
            statusTimeVM.statusVM.IdStatus = ((CbbItem)cbb_RoomStatus.SelectedItem).Value;
            statusTimeVM.StaName = ((CbbItem)cbb_RoomStatus.SelectedItem).text;
            roomDetailVM.ListStatusTime.Add(statusTimeVM);
            addDataGridView();
            dgv.Rows.Add(dtp_From.Value, dtp_To.Value, ((CbbItem)cbb_RoomStatus.SelectedItem).Value);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgv.SelectedRows;
            if (r.Count == 0) MessageBox.Show("Please choose rows to delete !!!");
            else
            {
                foreach (DataGridViewRow val in r)
                {
                    int id = Int32.Parse(val.Cells["IdStatim"].Value.ToString());
                    int i = val.Index;
                    roomDetailVM.ListStatusTime.RemoveAt(i);
                    if (id != 0) listdel.Add(id);
                }
            }
            addDataGridView();
        }
    }
}
