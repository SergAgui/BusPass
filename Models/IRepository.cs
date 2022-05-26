using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using QRCoder;


namespace BusPass.Models
{
    public interface IRepository
    {        
        FareModel FindFareId(int id);
        void NewFare(FareModel fare);
        void UpdateFare(FareModel fare);
        void RemoveFare(int id);
        List<FareModel> AllFares();

        ServiceAlertModel FindAlertId(int id);
        void NewAlert(ServiceAlertModel serviceAlert);
        void RemoveAlert(int id);
        public List<ServiceAlertModel> AllAlerts();

        public List<IdentityUser> AllUsers();
        public Task<string> UsersNameGet(string id);

        OrderModel FindOrderId(int id);
        void NewOrder(OrderModel order);
        void RemoveOrder(int id);
        List<OrderModel> OrderList();

        QRCode QRCode();
    }
}
