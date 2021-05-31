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
        public delegate void MyDel();
        public MyDel myDel;
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
            myDel();
            this.Dispose();
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            myDel();
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
