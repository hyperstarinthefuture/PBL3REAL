using AutoMapper;
using HotelManagement.DAL.Implement;
using HotelManagement.ViewModel;
using PBL3REAL.Extention;
using PBL3REAL.Model;
using PBL3REAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagement.BBL.Implement
{
    public class RoomTypeBLL
    {
        private RoomtypeDAL _roomTypeDAL;
        private ImgStorageDAL _imgStorageDAL;
     
        private Mapper mapper;

       
        public RoomTypeBLL()
        {
            _roomTypeDAL = new RoomtypeDAL();
            _imgStorageDAL = new ImgStorageDAL();
            mapper = new Mapper(MapperVM.config);
        }

        public List<RoomTypeVM> findByProperty(string search , string orderBy)
        {
            List<RoomTypeVM> listVM = new List<RoomTypeVM>();
            foreach (RoomType roomType in _roomTypeDAL.findByProperty(search,orderBy))
            {
                RoomTypeVM roomTypeVM = mapper.Map<RoomTypeVM>(roomType);
                listVM.Add(roomTypeVM);
            }
            return listVM;
        }

       

      

        public void addRoomType(RoomTypeVM roomTypeVM)
        {
            int idRoomType = _roomTypeDAL.getnextid();
            RoomType roomType = new RoomType();
            List<ImgStorage> imgstolist = new List<ImgStorage>();
            mapper.Map(roomTypeVM, roomType);
            roomType.RoTyActiveflag = true;
            foreach(ImageVM imageVM in roomTypeVM.ListImg)
            {
                ImgStorage imgStorage = new ImgStorage();
                mapper.Map(imageVM, imgStorage);
                imgStorage.ImgstoIdrootyp = idRoomType;
                imgstolist.Add(imgStorage);
            }
            roomType.ImgStorages = imgstolist;
            try
            {
                _roomTypeDAL.addRoomtype(roomType);
                _imgStorageDAL.add(imgstolist);
            }
            catch(Exception e)
            {

            }
           
        }
        public void editRoomType(RoomTypeVM roomTypeVM , List<int>listdel)
        {
            RoomType roomType = new RoomType();
            mapper.Map(roomTypeVM, roomType);
            List<ImgStorage> listadd = new List<ImgStorage>();
            foreach(ImageVM imageVM in roomTypeVM.ListImg)
            {
                ImgStorage imgStorage = new ImgStorage();
                mapper.Map(imageVM, imgStorage);
                imgStorage.ImgstoIdrootyp = roomType.IdRoomtype;
                if (imageVM.IdImgsto == 0) listadd.Add(imgStorage);
            }
           
            try
            {
                if (listdel != null) { _imgStorageDAL.delete(listdel); }
                _roomTypeDAL.updateRoomtype(roomType);
                _imgStorageDAL.add(listadd);
            }
            catch(Exception e)
            {

            }
            
        }

        public void deleteRoomType(int idRoomType)
        {
            _roomTypeDAL.deleteRoomtype(idRoomType);
        }

        public RoomTypeVM findbyid(int id)
        {
            RoomType roomType = _roomTypeDAL.findbyid(id);
            RoomTypeVM roomTypeVM = mapper.Map<RoomTypeVM>(roomType);
            foreach (ImgStorage img in roomType.ImgStorages)
            {
                ImageVM imageVM = mapper.Map<ImageVM>(img);
                 roomTypeVM.ListImg.Add(imageVM);
            }
            return roomTypeVM;
        }

        public List<CbbItem> addCombobox()
        {

            List<CbbItem> listcbb = new List<CbbItem>();
            foreach(RoomType roomType in _roomTypeDAL.findByProperty("",""))
            {
                CbbItem cbbItem = new CbbItem
                {
                    text = roomType.RotyName,
                    Value = roomType.IdRoomtype,
                };
                listcbb.Add(cbbItem);
            }
            return listcbb;
        }
    }
}


