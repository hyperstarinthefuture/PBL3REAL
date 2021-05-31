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
            listdel = new List<int>();
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
                        try 
                        {
                            using (FileStream fs = new FileStream(roomTypeVM.ListImg[5].ImgstoUrl, FileMode.Open))
                            {
                                picbx_Add6.Image = Image.FromStream(fs);
                                picbx_Add6.SizeMode = PictureBoxSizeMode.StretchImage;
                                fs.Close();
                            }
                            picbx_Add6.BackgroundImage = null;
                            picbx_Add6.AccessibleName = roomTypeVM.ListImg[5].IdImgsto.ToString();
                        }
                        catch (Exception e) { picbx_Add6.BackgroundImage = Properties.Resources.nothing_found_fluent_color_96px; }
                        TotalLoadedPic -= 1;
                        if (TotalLoadedPic > 0)
                        { goto case 5; }
                        break;
                    case 5:
                        try
                        {
                            using (FileStream fs = new FileStream(roomTypeVM.ListImg[4].ImgstoUrl, FileMode.Open))
                            {
                                picbx_Add5.Image = Image.FromStream(fs);
                                picbx_Add5.SizeMode = PictureBoxSizeMode.StretchImage;
                                fs.Close();
                            }
                            picbx_Add5.BackgroundImage = null;
                            picbx_Add5.AccessibleName = roomTypeVM.ListImg[4].IdImgsto.ToString();
                        }
                        catch (Exception e) { picbx_Add5.BackgroundImage = Properties.Resources.nothing_found_fluent_color_96px; }
                        TotalLoadedPic -= 1;
                        if (TotalPic == 5) { picbx_Add6.BackgroundImage = Properties.Resources.add_fluent_color_96px; }
                        if (TotalLoadedPic > 0)
                        { goto case 4; }
                        break;
                    case 4:
                        try 
                        {
                            using (FileStream fs = new FileStream(roomTypeVM.ListImg[3].ImgstoUrl, FileMode.Open))
                            {
                                picbx_Add4.Image = Image.FromStream(fs);
                                picbx_Add4.SizeMode = PictureBoxSizeMode.StretchImage;
                                fs.Close();
                            }
                            picbx_Add4.BackgroundImage = null;
                            picbx_Add4.AccessibleName = roomTypeVM.ListImg[3].IdImgsto.ToString();
                        }
                        catch (Exception e) { picbx_Add4.BackgroundImage = Properties.Resources.nothing_found_fluent_color_96px; }
                        TotalLoadedPic -= 1;
                        if (TotalPic == 4) { picbx_Add5.BackgroundImage = Properties.Resources.add_fluent_color_96px; }
                        if (TotalLoadedPic > 0)
                        { goto case 3; }
                        break;
                    case 3:
                        try
                        {
                            using (FileStream fs = new FileStream(roomTypeVM.ListImg[2].ImgstoUrl, FileMode.Open))
                            {
                                picbx_Add3.Image = Image.FromStream(fs);
                                picbx_Add3.SizeMode = PictureBoxSizeMode.StretchImage;
                                fs.Close();
                            }
                            picbx_Add3.BackgroundImage = null;
                            picbx_Add3.AccessibleName = roomTypeVM.ListImg[2].IdImgsto.ToString();
                        }
                        catch (Exception e) { picbx_Add3.BackgroundImage = Properties.Resources.nothing_found_fluent_color_96px; }
                        TotalLoadedPic -= 1;
                        if (TotalPic == 3) { picbx_Add4.BackgroundImage = Properties.Resources.add_fluent_color_96px; }
                        if (TotalLoadedPic > 0)
                        { goto case 2; }
                        break;
                    case 2:
                        try
                        {
                            using (FileStream fs = new FileStream(roomTypeVM.ListImg[1].ImgstoUrl, FileMode.Open))
                            {
                                picbx_Add2.Image = Image.FromStream(fs);
                                picbx_Add2.SizeMode = PictureBoxSizeMode.StretchImage;
                                fs.Close();
                            }
                            picbx_Add2.BackgroundImage = null;
                            picbx_Add2.AccessibleName = roomTypeVM.ListImg[1].IdImgsto.ToString();
                        }
                        catch (Exception e) { picbx_Add2.BackgroundImage = Properties.Resources.nothing_found_fluent_color_96px; }
                        TotalLoadedPic -= 1;
                        if (TotalPic == 2) { picbx_Add3.BackgroundImage = Properties.Resources.add_fluent_color_96px; }
                        if (TotalLoadedPic > 0)
                        { goto case 1; }
                        break;
                    case 1:
                        try
                        {
                            using (FileStream fs = new FileStream(roomTypeVM.ListImg[0].ImgstoUrl, FileMode.Open))
                            {
                                picbx_Add1.Image = Image.FromStream(fs);
                                picbx_Add1.SizeMode = PictureBoxSizeMode.StretchImage;
                                fs.Close();
                            }
                            picbx_Add1.BackgroundImage = null;
                            picbx_Add1.AccessibleName = roomTypeVM.ListImg[0].IdImgsto.ToString();
                        }
                        catch (Exception e) { picbx_Add1.BackgroundImage = Properties.Resources.nothing_found_fluent_color_96px; }
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
        //Update IMG 
        private void UpdatedIMG()
        {
            if (listdel.Count == 0)
            {
                if (roomTypeVM.ListImg.Count != TotalPic)
                {
                    //Chỉ add thêm
                    for (int i = roomTypeVM.ListImg.Count + 1; i <= roomTypeVM.ListImg.Count + TotalPicAdded; i++)
                    {
                        SaveIMG(i);
                    }   
                }
            }  
            else
            {
                if (TotalPicAdded == 0) 
                {
                    //Chỉ xóa đi
                    for (int i = roomTypeVM.ListImg.Count; i > TotalPic; i--)
                    {
                        DeleteIMG(i);
                    }
                }
                else
                {
                    if (roomTypeVM.ListImg.Count < TotalPic)
                    {
                        //Xóa đi r add lại nhìu hơn
                        for (int i = roomTypeVM.ListImg.Count - listdel.Count; i <= roomTypeVM.ListImg.Count; i++)
                        {
                            DeleteIMG(i);
                        }    
                        for (int i = roomTypeVM.ListImg.Count - listdel.Count; i <= TotalPic; i++)
                        {
                            SaveIMG(i);
                        }    
                    }    
                    else if (roomTypeVM.ListImg.Count > TotalPic)
                    {
                        //XÓa đi r add lại ít hơn
                        for (int i = roomTypeVM.ListImg.Count - listdel.Count; i <= roomTypeVM.ListImg.Count; i++)
                        {
                            DeleteIMG(i);
                        }
                        for (int i = roomTypeVM.ListImg.Count - listdel.Count; i <= TotalPic; i++)
                        {
                            SaveIMG(i);
                        }
                    }   
                    else
                    {
                        //Xóa đi bao nhiu add lại bấy nhiu
                        for (int i = 1; i <= roomTypeVM.ListImg.Count; i++)
                        {
                            DeleteIMG(i);
                        }    
                        for(int i = 1; i <= roomTypeVM.ListImg.Count; i++)
                        {
                            SaveIMG(i);
                        }    
                    }
                }    
            }    
        }
        //Delete IMG
        private void DeleteIMG(int index)
        {
            string path = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName + "\\RoomType\\";
            int TotalPicSaved = TotalPic;
            string fullpath = path + "RoomType_" + idRoomType.ToString();
            switch (index)
            {
                case 6:
                    fullpath = fullpath + "_6.Jpeg";
                    break;
                case 5:
                    fullpath = fullpath + "_5.Jpeg";
                    break;
                case 4:
                    fullpath = fullpath + "_4.Jpeg";
                    break;
                case 3:
                    fullpath = fullpath + "_3.Jpeg";
                    break;
                case 2:
                    fullpath = fullpath + "_2.Jpeg";
                    break;
                case 1:
                    fullpath = fullpath + "_1.Jpeg";
                    break;
                default:
                    break;
            }
            try
            {
                File.Delete(fullpath);
            }
            catch (Exception e) { }
        }
        //Save IMG
        private void SaveIMG(int index)
        {
            CreateStoragingFolder();
            string path = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName + "\\RoomType\\";
            string fullpath = path + "RoomType_" + idRoomType.ToString();
            switch (index)
            {
                case 6:
                    fullpath =  fullpath + "_6.Jpeg";
                    if (picbx_Add6.Image != null)
                    {
                        picbx_Add6.Image.Save(fullpath, System.Drawing.Imaging.ImageFormat.Jpeg);
                        roomTypeVM.ListImg.Add(new ImageVM { ImgstoUrl = fullpath });
                    }
                    break;
                case 5:
                    fullpath = fullpath + "_5.Jpeg";
                    if (picbx_Add5.Image != null)
                    {
                        picbx_Add5.Image.Save(fullpath, System.Drawing.Imaging.ImageFormat.Jpeg);
                        roomTypeVM.ListImg.Add(new ImageVM { ImgstoUrl = fullpath });
                    }
                    break;
                case 4:
                    fullpath = fullpath + "_4.Jpeg";
                    if (picbx_Add4.Image != null)
                    {
                        picbx_Add4.Image.Save(fullpath, System.Drawing.Imaging.ImageFormat.Jpeg);
                        roomTypeVM.ListImg.Add(new ImageVM { ImgstoUrl = fullpath });
                    }
                    break;
                case 3:
                    fullpath = fullpath + "_3.Jpeg";
                    if (picbx_Add3.Image != null)
                    {
                        picbx_Add3.Image.Save(fullpath, System.Drawing.Imaging.ImageFormat.Jpeg);
                        roomTypeVM.ListImg.Add(new ImageVM { ImgstoUrl = fullpath });
                    }
                    break;
                case 2:
                    fullpath = fullpath + "_2.Jpeg";
                    if (picbx_Add2.Image != null)
                    {
                        picbx_Add2.Image.Save(fullpath, System.Drawing.Imaging.ImageFormat.Jpeg);
                        roomTypeVM.ListImg.Add(new ImageVM { ImgstoUrl = fullpath });
                    }
                    break;
                case 1:
                    fullpath = fullpath + "_1.Jpeg";
                    if(picbx_Add1.Image != null)
                    {
                        picbx_Add1.Image.Save(fullpath, System.Drawing.Imaging.ImageFormat.Png);
                        roomTypeVM.ListImg.Add(new ImageVM { ImgstoUrl = fullpath });
                    }
                    break;
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
                    if (TotalPic > roomTypeVM.ListImg.Count) { TotalPicAdded += 1; }
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
                    if (TotalPic > roomTypeVM.ListImg.Count) { TotalPicAdded += 1; }
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
                    if (TotalPic > roomTypeVM.ListImg.Count) { TotalPicAdded += 1; }
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
                    if (TotalPic > roomTypeVM.ListImg.Count) { TotalPicAdded += 1; }
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
                    if (TotalPic > roomTypeVM.ListImg.Count) { TotalPicAdded += 1; }
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
                    if (TotalPic > roomTypeVM.ListImg.Count) { TotalPicAdded += 1; }
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
            if (idRoomType == 0)
            {
                //Add
                AddRoomType();
            }
            else
            {
                //Edit
                int capacity = 0 , price =0;
                int.TryParse(tb_RoomTypeCapacity.Text, out capacity);
                int.TryParse(tb_RoomTypePrice.Text, out price);
                UpdatedIMG();
                roomTypeVM.RotyCapacity = capacity;
                roomTypeVM.RotyName = tb_RoomTypeName.Text;
                roomTypeVM.RotyCurrentprice = price;
                roomTypeVM.RotyDescription = tb_RoomTypeDescription.Text;
                roomTypeBLL.editRoomType(roomTypeVM, listdel);
            }
            myDel();
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
