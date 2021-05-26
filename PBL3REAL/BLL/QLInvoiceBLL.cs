using AutoMapper;
using HotelManagement.DAL.Implement;
using PBL3REAL.DAL;
using PBL3REAL.Model;
using PBL3REAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PBL3REAL.BLL
{
    public class QLInvoiceBLL
    {
        private Mapper mapper;
        private RoomDAL roomDAL;
        private BookingDAL bookingDAL;
        public QLInvoiceBLL()
        {
            mapper = new Mapper(MapperVM.config);
            bookingDAL = new BookingDAL();
            roomDAL = new RoomDAL();
        }
        /*  public List<InvoiceVM> getAll()
          {
              List<InvoiceVM> listVM = new List<InvoiceVM>();
              foreach(Invoice invoice in InvoiceDAL.Instance.getAll())
              {
                  InvoiceVM invoiceVM = mapper.Map<InvoiceVM>(invoice);

              }
          }*/
        public InvoiceVM infoAddInvoice(string bookCode)
        {
            try
            {
                Booking booking = bookingDAL.findForInvoice(bookCode);
                if (booking == null) throw new ArgumentException("Wrong Code");
                InvoiceVM invoiceVM = new InvoiceVM
                {
                    BookCheckindate = booking.BookCheckindate,
                    BookChecoutdate = booking.BookCheckoutdate,
                    TotalPrice = booking.BookTotalprice,
                    CliCode = booking.BookIdclientNavigation.CliCode,
                    CliName = booking.BookIdclientNavigation.CliName,
                    CliPhone = booking.BookIdclientNavigation.CliPhone,
                };
                foreach (Room room in roomDAL.findByIdBook(booking.IdBook))
                {
                    invoiceVM.DicRoom.Add(room.RoomName, room.RoomIdroomtypeNavigation.RotyCurrentprice);
                }
                return invoiceVM;
            }
            catch (Exception)
            {
                throw; 
            }
        }
        public InvoiceVM getDetail(int idinvoice)
        {
            try
            {
                Invoice invoice = InvoiceDAL.Instance.findById(idinvoice);
                InvoiceVM invoiceVM = mapper.Map<InvoiceVM>(invoice);
                Booking booking = invoice.InvIdbookNavigation;
                invoiceVM.BookCheckindate = booking.BookCheckindate;
                invoiceVM.BookChecoutdate = booking.BookCheckoutdate;
                invoiceVM.CliName = booking.BookIdclientNavigation.CliName;
                invoiceVM.CliCode = booking.BookIdclientNavigation.CliCode;
                invoiceVM.CliPhone = booking.BookIdclientNavigation.CliPhone;
                invoiceVM.UserCode = booking.BookIduserNavigation.UserCode;
                
                foreach(Room room in roomDAL.findByIdBook(invoice.InvIdbook))
                {
                    invoiceVM.DicRoom.Add(room.RoomName , room.RoomIdroomtypeNavigation.RotyCurrentprice);
                }
                return invoiceVM;        
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<Statistic_InvoiceVM> findForStatistic(DateTime fromDate, DateTime toDate)
        {
            List<Statistic_InvoiceVM> listVM = new List<Statistic_InvoiceVM>();
            var GroupByInv = InvoiceDAL.Instance.findForStatistic(fromDate, toDate);
            foreach (var inv in GroupByInv)
            {
                Statistic_InvoiceVM statistic_InvoiceVM = new Statistic_InvoiceVM
                {
                    Date = inv.InvCreatedate,
                    TotalByDate = inv.TotalPrice
                };
                listVM.Add(statistic_InvoiceVM);
            }
            return listVM;
        }
    }
}
