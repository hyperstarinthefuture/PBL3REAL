using AutoMapper;
using HotelManagement.ViewModel;
using PBL3REAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PBL3REAL.ViewModel
{
   public class MapperVM
    {
        public static MapperConfiguration config = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<Booking, BookingVM>().ReverseMap();
            cfg.CreateMap<Booking, BookingDetailVM>().ReverseMap();
            cfg.CreateMap<BookingDetail, SubBookingDetailVM>().ReverseMap();
            cfg.CreateMap<Client, ClientVM>().ReverseMap();
            cfg.CreateMap<Room, RoomVM>().ReverseMap();
            cfg.CreateMap<Status, StatusVM>().ReverseMap();
            cfg.CreateMap<StatusTime, StatusTimeVM>().ReverseMap();
            cfg.CreateMap<Room, RoomDetailVM>().ReverseMap();
            cfg.CreateMap<RoomType, RoomTypeVM>().ReverseMap();
            cfg.CreateMap<ImgStorage, ImageVM>().ReverseMap();
            cfg.CreateMap<User, UserVM>().ReverseMap();
            cfg.CreateMap<Role, RoleVM>().ReverseMap();
            cfg.CreateMap<Invoice, InvoiceVM>().ReverseMap();

        });
    }
}
