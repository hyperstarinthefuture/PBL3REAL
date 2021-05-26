using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using HotelManagement.BBL.Implement;
using HotelManagement.BLL.Implement;
using HotelManagement.DAL.Implement;
using HotelManagement.ViewModel;
using Newtonsoft.Json;
using PBL3REAL.BLL;
using PBL3REAL.DAL;
using PBL3REAL.Model;
using PBL3REAL.ViewModel;
namespace PBL3REAL.View
{
    public partial class Form_Detail_Room_Category : Form
    {
        public delegate void MyDel();
        public MyDel myDel;
        private RoomTypeBLL roomTypeBLL;
        private QLUserBLL userBLL;
        private int idRoomType;
        private int TotalPic = 0;
        private int TotalPicAdded = 0;
        RoomTypeVM roomTypeVM;
        private List<int> listdel;
        public Form_Detail_Room_Category(int idRoomType, bool Editable)
        {
            InitializeComponent();
            roomTypeBLL = new RoomTypeBLL();
            LoadData(idRoomType,Editable);
            this.idRoomType = idRoomType;
            userBLL = new QLUserBLL();
            listdel = new List<int>();
            string tempname = tb_RoomTypeCapacity.Text;
        }
        //Loading Data Function
        public void LoadData(int idroomtype, bool Editable) 
        {
            if (idroomtype == 0)
            {
                //Add room type
            }   
            else
            {
                //View or edit
                roomTypeVM = roomTypeBLL.findbyid(idroomtype);
                tb_RoomTypeName.Text = roomTypeVM.RotyName;
                tb_RoomTypeDescription.Text = roomTypeVM.RotyDescription;
                tb_RoomTypePrice.Text = roomTypeVM.RotyCurrentprice.ToString();
                tb_RoomTypeCapacity.Text = roomTypeVM.RotyCapacity.ToString();
                TotalPic = roomTypeVM.ListImg.Count;
                int TotalLoadedPic = TotalPic;
                switch (TotalLoadedPic)
                {
                    case 6:
                        using (FileStream fs = new FileStream(roomTypeVM.ListImg[5].ImgstoUrl, FileMode.Open))
                        {
                            picbx_Add6.Image = Image.FromStream(fs);
                            picbx_Add6.SizeMode = PictureBoxSizeMode.StretchImage;
                            fs.Close();
                        }
                        picbx_Add6.BackgroundImage = null;
                        picbx_Add6.AccessibleName = roomTypeVM.ListImg[5].IdImgsto.ToString();
                        TotalLoadedPic -= 1;
                        if (TotalLoadedPic > 0)
                        { goto case 5; }
                        else
                            break;
                    case 5:
                        using (FileStream fs = new FileStream(roomTypeVM.ListImg[4].ImgstoUrl, FileMode.Open))
                        {
                            picbx_Add5.Image = Image.FromStream(fs);
                            picbx_Add5.SizeMode = PictureBoxSizeMode.StretchImage;
                            fs.Close();
                        }
                        picbx_Add5.BackgroundImage = null;
                        picbx_Add5.AccessibleName = roomTypeVM.ListImg[4].IdImgsto.ToString();
                        TotalLoadedPic -= 1;
                        if (TotalPic == 5) { picbx_Add6.BackgroundImage = Properties.Resources.add_fluent_color_96px; }
                        if (TotalLoadedPic > 0)
                        { goto case 4; }
                        else
                            break;
                    case 4:
                        using (FileStream fs = new FileStream(roomTypeVM.ListImg[3].ImgstoUrl, FileMode.Open))
                        {
                            picbx_Add4.Image = Image.FromStream(fs);
                            picbx_Add4.SizeMode = PictureBoxSizeMode.StretchImage;
                            fs.Close();
                        }
                        picbx_Add4.BackgroundImage = null;
                        picbx_Add4.AccessibleName = roomTypeVM.ListImg[3].IdImgsto.ToString();
                        TotalLoadedPic -= 1;
                        if (TotalPic == 4) { picbx_Add5.BackgroundImage = Properties.Resources.add_fluent_color_96px; }
                        if (TotalLoadedPic > 0)
                        { goto case 3; }
                        else
                            break;
                    case 3:
                        using (FileStream fs = new FileStream(roomTypeVM.ListImg[2].ImgstoUrl, FileMode.Open))
                        {
                            picbx_Add3.Image = Image.FromStream(fs);
                            picbx_Add3.SizeMode = PictureBoxSizeMode.StretchImage;
                            fs.Close();
                        }
                        picbx_Add3.BackgroundImage = null;
                        picbx_Add3.AccessibleName = roomTypeVM.ListImg[2].IdImgsto.ToString();
                        TotalLoadedPic -= 1;
                        if (TotalPic == 3) { picbx_Add4.BackgroundImage = Properties.Resources.add_fluent_color_96px; }
                        if (TotalLoadedPic > 0)
                        { goto case 2; }
                        else
                            break;
                    case 2:
                        using (FileStream fs = new FileStream(roomTypeVM.ListImg[1].ImgstoUrl, FileMode.Open))
                        {
                            picbx_Add2.Image = Image.FromStream(fs);
                            picbx_Add2.SizeMode = PictureBoxSizeMode.StretchImage;
                            fs.Close();
                        }
                        picbx_Add2.BackgroundImage = null;
                        picbx_Add2.AccessibleName = roomTypeVM.ListImg[1].IdImgsto.ToString();
                        TotalLoadedPic -= 1;
                        if (TotalPic == 2) { picbx_Add3.BackgroundImage = Properties.Resources.add_fluent_color_96px; }
                        if (TotalLoadedPic > 0)
                        { goto case 1; }
                        else
                            break;
                    case 1:
                        using (FileStream fs = new FileStream(roomTypeVM.ListImg[0].ImgstoUrl, FileMode.Open))
                        {
                            picbx_Add1.Image = Image.FromStream(fs);
                            picbx_Add1.SizeMode = PictureBoxSizeMode.StretchImage;
                            fs.Close();
                        }
                        picbx_Add1.BackgroundImage = null;
                        picbx_Add1.AccessibleName = roomTypeVM.ListImg[0].IdImgsto.ToString();
                        if (TotalPic == 1) { picbx_Add2.BackgroundImage = Properties.Resources.add_fluent_color_96px; }
                        break;
                    default:
                        break;
                }
            }   
            if (!Editable)
            {
                grbx_RoomTypeDetail.Enabled = false;
                btn_Del.Enabled = false;
                btn_OK.Enabled = false;
                btn_Reset.Enabled = false;
            }    
        }
        //Reset Function
        private void ResetData() { }
        //Create Storaging Folder
        private void CreateStoragingFolder()
        {
            //string palettesPath = "..\\Room_Type";
            string palettesPath = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName + "\\RoomType";
            try
            {
                // If the directory doesn't exist, create it.
                if (!System.IO.Directory.Exists(palettesPath))
                {
                    System.IO.Directory.CreateDirectory(palettesPath);
                }
            }
            catch (Exception)
            {
                // Fail silently
                MessageBox.Show("Error!");
            }
        }
        //Insert IMG
        private Image InsertIMG()
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                return new Bitmap(open.FileName);
            }
            return null;
        }
        //Save IMG
        private void SaveIMG()
        {
            CreateStoragingFolder();
            //string path = "..\\Properties\\Room_Type\\";
            string path = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName + "\\RoomType\\";
            int TotalPicSaved = TotalPic;
            string fullpath;
            switch (TotalPic)
            {
                case 6:
                    fullpath = path + "RoomType_" + idRoomType.ToString() + "_6.Jpeg";
                    if (File.Exists(fullpath)) { File.Delete(fullpath); }
                    if (picbx_Add6.Image != null)
                    {
                        picbx_Add6.Image.Save(fullpath, System.Drawing.Imaging.ImageFormat.Jpeg);
                        roomTypeVM.ListImg.Add(new ImageVM { ImgstoUrl = fullpath });
                    }
                    TotalPicSaved -= 1;
                    if (TotalPicSaved == 0) { return; }
                    goto case 5;
                case 5:
                    fullpath = path + "RoomType_" + idRoomType.ToString() + "_5.Jpeg";
                    if (File.Exists(fullpath)) { File.Delete(fullpath); }
                    if (picbx_Add5.Image != null)
                    {
                        picbx_Add5.Image.Save(fullpath, System.Drawing.Imaging.ImageFormat.Jpeg);
                        roomTypeVM.ListImg.Add(new ImageVM { ImgstoUrl = fullpath });
                    }
                    TotalPicSaved -= 1;
                    if (TotalPicSaved == 0) { return; }
                    goto case 4;
                case 4:
                    fullpath = path + "RoomType_" + idRoomType.ToString() + "_4.Jpeg";
                    if (File.Exists(fullpath)) { File.Delete(fullpath); }
                    if (picbx_Add4.Image != null)
                    {
                        picbx_Add4.Image.Save(fullpath, System.Drawing.Imaging.ImageFormat.Jpeg);
                        roomTypeVM.ListImg.Add(new ImageVM { ImgstoUrl = fullpath });
                    }
                    TotalPicSaved -= 1;
                    if (TotalPicSaved == 0) { return; }
                    goto case 3;
                case 3:
                    fullpath = path + "RoomType_" + idRoomType.ToString() + "_3.Jpeg";
                    if (File.Exists(fullpath)) { File.Delete(fullpath); }
                    if (picbx_Add3.Image != null)
                    {
                        picbx_Add3.Image.Save(fullpath, System.Drawing.Imaging.ImageFormat.Jpeg);
                        roomTypeVM.ListImg.Add(new ImageVM { ImgstoUrl = fullpath });
                    }
                    TotalPicSaved -= 1;
                    if (TotalPicSaved == 0) { return; }
                    goto case 2;
                case 2:
                    fullpath = path + "RoomType_" + idRoomType.ToString() + "_2.Jpeg";
                    if (File.Exists(fullpath)) { File.Delete(fullpath); }
                    if (picbx_Add2.Image != null)
                    {
                        picbx_Add2.Image.Save(fullpath, System.Drawing.Imaging.ImageFormat.Jpeg);
                        roomTypeVM.ListImg.Add(new ImageVM { ImgstoUrl = fullpath });
                    }
                    TotalPicSaved -= 1;
                    if (TotalPicSaved == 0) { return; }
                    goto case 2;
                case 1:
                    fullpath = path + "RoomType_" + idRoomType.ToString() + "_1.Jpeg";
                    if (File.Exists(fullpath)) { File.Delete(fullpath); }
                    if(picbx_Add1.Image != null)
                    {
                        picbx_Add1.Image.Save(fullpath, System.Drawing.Imaging.ImageFormat.Png);
                        roomTypeVM.ListImg.Add(new ImageVM { ImgstoUrl = fullpath });
                    }
                    return;
                default:
                    break;
            }    
        }
        //Room Type Processing Functions
        private void AddRoomType()
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
        private void EditRoomType(int res)
        {
            string temp1 = tb_RoomTypeCapacity.Text;
            switch (TotalPic - TotalPicAdded)
            {
                case 6:
                    break;
                default:
                    SaveIMG();
                    break;
            }
            roomTypeVM.RotyCapacity = res;
            List<int> temp = listdel;
            roomTypeBLL.editRoomType(roomTypeVM, temp);
        }
        //Events
        private void picbx_add1_Click(object sender, EventArgs e)
        {
            if (TotalPic == 0)
            {
                Image temp = new Bitmap(picbx_Add1.BackgroundImage);
                picbx_Add1.BackgroundImage = null;
                picbx_Add1.Image = InsertIMG();
                if (picbx_Add1.Image != null)
                {
                    picbx_Add1.SizeMode = PictureBoxSizeMode.StretchImage;
                    picbx_Add2.BackgroundImage = temp;
                    TotalPic += 1;
                    TotalPicAdded += 1;
                }
                else
                {
                    picbx_Add1.BackgroundImage = Properties.Resources.add_fluent_color_96px;
                }
            }
        }
        private void picbx_add2_Click(object sender, EventArgs e)
        {
            if (TotalPic == 1)
            {
                Image temp = new Bitmap(picbx_Add2.BackgroundImage);
                picbx_Add2.BackgroundImage = null;
                picbx_Add2.Image = InsertIMG();
                if (picbx_Add2.Image != null)
                {
                    picbx_Add2.SizeMode = PictureBoxSizeMode.StretchImage;
                    picbx_Add3.BackgroundImage = temp;
                    TotalPic += 1;
                    TotalPicAdded += 1;
                }
                else
                {
                    picbx_Add2.BackgroundImage = Properties.Resources.add_fluent_color_96px;
                }
            }
        }
        private void picbx_add3_Click(object sender, EventArgs e)
        {
            if (TotalPic == 2)
            {
                Image temp = new Bitmap(picbx_Add3.BackgroundImage);
                picbx_Add3.BackgroundImage = null;
                picbx_Add3.Image = InsertIMG();
                if (picbx_Add3.Image != null)
                {
                    picbx_Add3.SizeMode = PictureBoxSizeMode.StretchImage;
                    picbx_Add4.BackgroundImage = temp;
                    TotalPic += 1;
                    TotalPicAdded += 1;
                }
                else
                {
                    picbx_Add3.BackgroundImage = Properties.Resources.add_fluent_color_96px;
                }
            }
        }
        private void picbx_add4_Click(object sender, EventArgs e)
        {
            if (TotalPic == 3)
            {
                Image temp = new Bitmap(picbx_Add4.BackgroundImage);
                picbx_Add4.BackgroundImage = null;
                picbx_Add4.Image = InsertIMG();
                if (picbx_Add4.Image != null)
                {
                    picbx_Add4.SizeMode = PictureBoxSizeMode.StretchImage;
                    picbx_Add5.BackgroundImage = temp;
                    TotalPic += 1;
                    TotalPicAdded += 1;
                }
                else
                {
                    picbx_Add4.BackgroundImage = Properties.Resources.add_fluent_color_96px;
                }
            }
        }
        private void picbx_add5_Click(object sender, EventArgs e)
        {
            if (TotalPic == 4)
            {
                Image temp = new Bitmap(picbx_Add5.BackgroundImage);
                picbx_Add5.BackgroundImage = null;
                picbx_Add5.Image = InsertIMG();
                if (picbx_Add5.Image != null)
                {
                    picbx_Add5.SizeMode = PictureBoxSizeMode.StretchImage;
                    picbx_Add6.BackgroundImage = temp;
                    TotalPic += 1;
                    TotalPicAdded += 1;
                }
                else
                {
                    picbx_Add5.BackgroundImage = Properties.Resources.add_fluent_color_96px;
                }
            }
        }
        private void picbx_add6_Click(object sender, EventArgs e)
        {
            if (TotalPic == 5)
            {
                picbx_Add6.BackgroundImage = null;
                picbx_Add6.Image = InsertIMG();
                if (picbx_Add6.Image != null)
                {
                    picbx_Add6.SizeMode = PictureBoxSizeMode.StretchImage;
                    TotalPic += 1;
                    TotalPicAdded += 1;
                }
                else
                {
                    picbx_Add6.BackgroundImage = Properties.Resources.add_fluent_color_96px;
                }
            } 
        }
        private void btn_OK_Click(object sender, EventArgs e)
        {
            //Gọi hàm BLL xử lí nghiệp vụ
            //myDel();
            string TEMPNAME = tb_RoomTypeCapacity.Text;
            if (listdel.Count == 0)
            {
                //this.Dispose();
            }
            if (idRoomType == 0)
            {
                //Add
                AddRoomType();
            }
            else
            {
                //Edit
                int res = 0;
                int.TryParse(tb_RoomTypeCapacity.Text, out res);
                EditRoomType(res);
            }
            this.Dispose();
        }
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            //Gọi hàm xóa tất cả dữ liệu đã nhập hoặc có sẵn trước đó
            ResetData();
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            switch(TotalPic)
            {
                case 0:
                    MessageBox.Show("Đã xóa hết ảnh!", "Thông báo", MessageBoxButtons.OK);
                    break;
                case 1:
                    picbx_Add1.Image = null;
                    picbx_Add1.BackgroundImage = Properties.Resources.add_fluent_color_96px;
                    picbx_Add2.BackgroundImage = Properties.Resources.select_none_fluent_color_96px;
                    TotalPic -= 1;
                    if (TotalPicAdded > 0) { TotalPicAdded -= 1; }
                    if (picbx_Add1.AccessibleName != null) 
                    { 
                        listdel.Add(roomTypeVM.ListImg[0].IdImgsto);
                        picbx_Add1.AccessibleName = null;
                    }
                    MessageBox.Show("Đã xóa hết ảnh!", "Thông báo", MessageBoxButtons.OK);
                    break;
                case 2:
                    picbx_Add2.Image = null;
                    picbx_Add2.BackgroundImage = Properties.Resources.add_fluent_color_96px;
                    picbx_Add3.BackgroundImage = Properties.Resources.select_none_fluent_color_96px;
                    TotalPic -= 1;
                    if (TotalPicAdded > 0) { TotalPicAdded -= 1; }
                    if (picbx_Add2.AccessibleName != null)
                    {
                        listdel.Add(roomTypeVM.ListImg[1].IdImgsto);
                        picbx_Add2.AccessibleName = null;
                    }
                    break;
                case 3:
                    picbx_Add3.Image = null;
                    picbx_Add3.BackgroundImage = Properties.Resources.add_fluent_color_96px;
                    picbx_Add4.BackgroundImage = Properties.Resources.select_none_fluent_color_96px;
                    TotalPic -= 1;
                    if (TotalPicAdded > 0) { TotalPicAdded -= 1; }
                    if (picbx_Add3.AccessibleName != null)
                    {
                        listdel.Add(roomTypeVM.ListImg[2].IdImgsto);
                        picbx_Add3.AccessibleName = null;
                    }
                    break;
                case 4:
                    picbx_Add4.Image = null;
                    picbx_Add4.BackgroundImage = Properties.Resources.add_fluent_color_96px;
                    picbx_Add5.BackgroundImage = Properties.Resources.select_none_fluent_color_96px;
                    TotalPic -= 1;
                    if (TotalPicAdded > 0) { TotalPicAdded -= 1; }
                    if (picbx_Add4.AccessibleName != null)
                    {
                        listdel.Add(roomTypeVM.ListImg[3].IdImgsto);
                        picbx_Add4.AccessibleName = null;
                    }
                    break;
                case 5:
                    picbx_Add5.Image = null;
                    picbx_Add5.BackgroundImage = Properties.Resources.add_fluent_color_96px;
                    picbx_Add6.BackgroundImage = Properties.Resources.select_none_fluent_color_96px;
                    TotalPic -= 1;
                    if (TotalPicAdded > 0) { TotalPicAdded -= 1; }
                    if (picbx_Add5.AccessibleName != null)
                    {
                        listdel.Add(roomTypeVM.ListImg[4].IdImgsto);
                        picbx_Add5.AccessibleName = null;
                    }
                    break;
                case 6:
                    picbx_Add6.Image = null;
                    picbx_Add6.BackgroundImage = Properties.Resources.add_fluent_color_96px;
                    TotalPic -= 1;
                    if (TotalPicAdded > 0) { TotalPicAdded -= 1; }
                    if (picbx_Add6.AccessibleName != null)
                    {
                        listdel.Add(roomTypeVM.ListImg[5].IdImgsto);
                        picbx_Add6.AccessibleName = null;
                    }
                    break;
            }    
        }
    }
}
